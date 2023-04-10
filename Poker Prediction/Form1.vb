Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Linq.Expressions
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles
Imports System

Public Structure Card
    Public _face As Bitmap
    Public _suit As Integer
    Public _value As Integer
End Structure
Public Structure opponent
    Public _folded As Boolean
End Structure

Public Structure HandValue
    Public _type As Byte
    Public _highest As Byte
End Structure

Public Class Form1
    Public Shared opponents As Integer
    Public Shared Deck(3, 12) As Card
    Public Shared FlopCards() As Card = Array.Empty(Of Card)
    Public Shared HandCards() As Card = Array.Empty(Of Card)
    ' Public Shared opponentArr() As opponent
    Public Shared opponentCards(,) As Card = {}
    Public Shared visibleCards As Integer = 0
    Public Function compileCard(Value As Integer, Suit As Integer) As Bitmap
        Dim bmp As Bitmap = CardBodyList.Images.Item(0)
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        gfx.DrawImage(ValueList.Images.Item(Value), 6, 5)
        gfx.DrawImage(ValueList.Images.Item(Value), 46, 67)
        gfx.DrawImage(SuitList.Images.Item(Suit), 4, 13)
        gfx.DrawImage(SuitList.Images.Item(Suit), 44, 75)
        Return bmp
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Suit = 0 To 3
            For Value = 0 To 12
                Deck(Suit, Value)._face = compileCard(Value, Suit)
                Deck(Suit, Value)._suit = Suit
                Deck(Suit, Value)._value = Value
            Next
        Next
        foldBtn.Enabled = False
        callBtn.Enabled = False
        RaiseBtn.Enabled = False
        raise.ReadOnly = True
        RestartBtn.Enabled = False



    End Sub
    Public Function compileCardList(cardArr() As Card) As Bitmap
        Dim bmp As New Bitmap(118, 87)
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        Dim imageIndex As Integer = 0
        Dim imageOffset As Integer = 0
        For Each card In cardArr
            If imageIndex < visibleCards Or cardArr.Length <= 2 Then
                gfx.DrawImage(card._face, imageOffset, 0)
            Else
                gfx.DrawImage(CardBodyList.Images.Item(1), imageOffset, 0)
            End If


            imageIndex += 1
            imageOffset = imageIndex * 15
        Next
        Return bmp
    End Function
    Public Sub addToFlop(card As Card)
        If FlopCards.Length < 5 Then
            ReDim Preserve FlopCards(FlopCards.Length)
            FlopCards(FlopCards.GetUpperBound(0)) = Deck(card._suit, card._value)
            Flop.Image = compileCardList(FlopCards)
        End If
    End Sub
    Public Sub addToOpponent(opponentnum As Integer, card As Card)
        ReDim Preserve opponentCards(opponents, 1)
        'ReDim Preserve opponentArr(opponents)
        opponentCards(opponentnum, opponentCards.GetUpperBound(1)) = Deck(card._suit, card._value)
    End Sub
    Public Sub addToHand(ByRef card As Card)
        If HandCards.Length < 2 Then
            ReDim Preserve HandCards(HandCards.Length)
            HandCards(HandCards.GetUpperBound(0)) = Deck(card._suit, card._value)
            Hand.Image = compileCardList(HandCards)
        End If
    End Sub
    Public Sub insertCard(ByRef Arr() As Card, value As Card)
        ReDim Preserve Arr(Arr.Length)
        Arr(Arr.GetUpperBound(0)) = value
    End Sub
    Public Sub insertInteger(ByRef Arr() As Integer, value As Integer)
        ReDim Preserve Arr(Arr.Length)
        Arr(Arr.GetUpperBound(0)) = value
    End Sub
    Public Function handScore() As Integer
        Dim fullDeck() As Card
        fullDeck = FlopCards
        For Each card In HandCards
            insertCard(fullDeck, card)
        Next


        'Find suit frequency

        Dim clubs, spades, diamonds, hearts As Byte
        Dim clubsCard(0), spadesCard(0), diamondsCard(0), heartsCard(0) As Card
        For Each card In fullDeck
            Select Case card._suit
                Case Is = 0
                    clubs += 1
                    insertCard(clubsCard, card)
                Case Is = 1
                    spades += 1
                    insertCard(spadesCard, card)
                Case Is = 2
                    diamonds += 1
                    insertCard(diamondsCard, card)
                Case Is = 3
                    hearts += 1
                    insertCard(heartsCard, card)
            End Select
        Next
        Dim flushDeck() As Card
        Dim flush As Boolean = False
        If clubs >= 5 Then
            flushDeck = clubsCard
            flush = True
        ElseIf spades >= 5 Then
            flushDeck = spadesCard
            flush = True
        ElseIf diamonds >= 5 Then
            flushDeck = diamondsCard
            flush = True
        ElseIf hearts >= 5 Then
            flushDeck = heartsCard
            flush = True
        End If
        If flush Then
            sortCards(flushDeck)
            If containsStraight(flushDeck) Then
                If flushDeck(flushDeck.GetUpperBound(0))._value = 12 Then
                    Return 10    'Royal flush
                Else
                    Return 9     'Straight flush
                End If
            Else
                Return 6          'flush
            End If
        End If



        Dim Values(13) As Integer
        For Each card In fullDeck
            Values(card._value) += 1
        Next

        For index = 0 To 12
            If Values(index) >= 4 Then
                Return 8            ' 4 of a kind
            End If
        Next
        Dim triples, doubles As Byte
        For index = 0 To 12
            If Values(index) = 3 Then
                triples += 1
            End If
            If Values(index) = 2 Then
                doubles += 1
            End If
        Next
        If triples > 0 And doubles > 0 Then
            Return 7                    ' full house
        End If

        sortCards(fullDeck)
        If containsStraight(fullDeck) Then
            Return 5
        End If

        If triples > 0 Then
            Return 4
        End If

        If doubles > 1 Then
            Return 3
        End If

        If doubles > 0 Then
            Return 2
        End If

        For Each card In HandCards
            If card._value >= 8 Then
                Return 1
            End If
        Next
        Return 0

        Return 0
    End Function
    Public Function containsStraight(deck() As Card) As Boolean
        For startID = 0 To deck.Length - 5
            Dim cards As List(Of Integer) = New List(Of Integer)
            Dim isStraight As Boolean = False
            For ID = startID To startID + 5
                cards.Add(deck(ID)._value)
            Next


            Dim areMultipleNumbersInList As Boolean = cards.GroupBy(Function(x) x).Any(Function(x) x.Count() > 1)

            Dim max As Integer = cards.Max()
            Dim min As Integer = cards.Min()

            If (max - min = 4 AndAlso Not areMultipleNumbersInList) Then
                Return True
            End If
            Return False
        Next
    End Function
    Public Sub sortCards(ByRef data() As Card)

        Dim min As Integer

        For i As Integer = 0 To data.Length - 2
            min = i

            For j As Integer = i + 1 To data.Length - 1
                If data(j)._value < data(min)._value Then
                    min = j
                End If
            Next

            Dim temp As Integer = data(min)._value
            data(min)._value = data(i)._value
            data(i)._value = temp
        Next
    End Sub




    Public Sub DisplayValue()
        Select Case handScore()
            Case Is = 10
                TextBox3.Text = "Royal flush"
            Case Is = 9
                TextBox3.Text = "Straight flush"
            Case Is = 8
                TextBox3.Text = "4 of a kind"
            Case Is = 7
                TextBox3.Text = "Full house"
            Case Is = 6
                TextBox3.Text = "Flush"
            Case Is = 5
                TextBox3.Text = "Straight"
            Case Is = 4
                TextBox3.Text = "3 of a kind"
            Case Is = 3
                TextBox3.Text = "Two 2 of a kind's"
            Case Is = 2
                TextBox3.Text = "2 of a kind"
            Case Is = 1
                TextBox3.Text = "High card"
            Case Is = 0
                TextBox3.Text = "None"
        End Select
    End Sub
    Public Sub advance()
        Select Case visibleCards
            Case Is = 0
                visibleCards = 3
                'opponentOption()
                'If foldWin() Then
                'payout()
                'endGame()
                'End If
                Flop.Image = compileCardList(FlopCards)
            Case Is = 3
                visibleCards = 4
                'opponentOption()
                ' If foldWin() Then
                'payout()
                'endGame()
                'End If
                Flop.Image = compileCardList(FlopCards)
            Case Is = 4
                visibleCards = 5
                DisplayValue()
                predictOpponents()
                endGame()
        End Select


    End Sub
    'Public Function foldWin() As Boolean
    'For Each opponent In opponentArr
    'If opponent._folded <> True Then
    'Return False
    'End If
    'Next
    'Return True
    'End Function
    'Public Sub opponentOption()
    '    For oppNum = 0 To opponents - 1
    '        Dim rand As New Random
    '        rand.Next(0, 1001)
    '        If opponentValue(oppNum) = 0 Then
    '            If rand.Next(0, 1001) < 800 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 1 Then
    '            If rand.Next(0, 1001) < 600 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 2 Then
    '            If rand.Next(0, 1001) < 400 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 3 Then
    '            If rand.Next(0, 1001) < 300 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 4 Then
    '            If rand.Next(0, 1001) < 250 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 5 Then
    '            If rand.Next(0, 1001) < 200 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 6 Then
    '            If rand.Next(0, 1001) < 150 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 7 Then
    '            If rand.Next(0, 1001) < 100 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 8 Then
    '            If rand.Next(0, 1001) < 75 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 9 Then
    '            If rand.Next(0, 1001) < 50 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If
    '        If opponentValue(oppNum) = 10 Then
    '            If rand.Next(0, 1001) < 10 Then
    '                opponentArr(oppNum)._folded = True
    '            End If
    '        End If


    '    Next
    'End Sub
    Public Sub randomise()
        FlopCards = Array.Empty(Of Card)
        HandCards = Array.Empty(Of Card)
        Dim rand As New Random
        Dim card As Card
        For i = 0 To 4
            card._suit = rand.Next(0, 4)
            card._value = rand.Next(0, 13)
            card._face = compileCard(card._value, card._suit)
            addToFlop(card)
        Next
        For i = 0 To 1
            card._suit = rand.Next(0, 4)
            card._value = rand.Next(0, 13)
            card._face = compileCard(card._value, card._suit)
            addToHand(card)
        Next

        For oppNum = 0 To Integer.Parse(opponentNum.Text) - 1
            For i = 0 To 1
                card._suit = rand.Next(0, 4)
                card._value = rand.Next(0, 13)
                card._face = compileCard(card._value, card._suit)
                addToOpponent(oppNum, card)
            Next
        Next

    End Sub

    Private Sub foldBtn_Click(sender As Object, e As EventArgs) Handles foldBtn.Click
        endGame()
        DisplayValue()
    End Sub

    Private Sub callBtn_Click(sender As Object, e As EventArgs) Handles callBtn.Click
        currentLoss.Text = minimumBet.Text
        advance()
    End Sub

    Private Sub RaiseBtn_Click(sender As Object, e As EventArgs) Handles RaiseBtn.Click

        If Integer.Parse(raise.Text) + Integer.Parse(currentLoss.Text) > Integer.Parse(allowance.Text) Then
            raise.Text = Math.Clamp(Integer.Parse(allowance.Text) - Integer.Parse(currentLoss.Text), 0, 10000000000)
        End If
        If raise.Text <> 0 Then
            currentLoss.Text += Integer.Parse(raise.Text)
            minimumBet.Text = currentLoss.Text
            advance()
        End If
    End Sub

    Private Sub RestartBtn_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        restartGame()
    End Sub
    Public Sub endGame()
        allowance.Text = allowance.Text - currentLoss.Text
        visibleCards = 5
        Flop.Image = compileCardList(FlopCards)
        FlopCards = Array.Empty(Of Card)
        HandCards = Array.Empty(Of Card)
        opponentCards = {}
        'opponentArr = {}
        foldBtn.Enabled = False
        callBtn.Enabled = False
        RaiseBtn.Enabled = False
        raise.ReadOnly = True
        RestartBtn.Enabled = True
        opponentNum.Enabled = True

    End Sub
    Public Sub restartGame()
        If allowance.Text > 5 Then
            visibleCards = 0
            foldBtn.Enabled = True
            callBtn.Enabled = True
            RaiseBtn.Enabled = True
            raise.ReadOnly = False
            currentLoss.Text = 5
            minimumBet.Text = 5
            RestartBtn.Enabled = False
            opponentNum.Enabled = False
            randomise()
        Else
            TextBox3.Text = "You are out of money."
        End If
    End Sub

    Private Sub opponentNum_TextChanged(sender As Object, e As EventArgs) Handles opponentNum.TextChanged
        Try
            If opponentNum.Text >= 1 And opponentNum.Text <= 9 Then
                opponents = opponentNum.Text
                restartGame()

                opponentNum.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function predictOpponents()
        Dim Scores(opponentNum.Text) As Integer
        For oppNum = 0 To (opponentNum.Text - 1)
            'If opponentArr(oppNum)._folded = False Then
            Scores(oppNum) = opponentValue(oppNum)
            'Else
            'Scores(oppNum) = 0
            'End If
        Next


        Dim maximum As Integer = 0
        For Each score In Scores
            If score > maximum Then
                maximum = score
            End If
        Next
        If handScore() > maximum Then
            TextBox3.Text &= ", You win! (" & maximum & ")"
            payout()
        ElseIf handScore = maximum Then

        Else
            TextBox3.Text &= ", You lose! (" & maximum & ")"
        End If

    End Function
    Public Sub payout()
        allowance.Text += minimumBet.Text * (opponentNum.Text + 1)
    End Sub

    Public Function opponentValue(oppNum As Integer) As Integer
        Dim fullDeck() As Card
        fullDeck = FlopCards
        insertCard(fullDeck, opponentCards(oppNum, 0))
        insertCard(fullDeck, opponentCards(oppNum, 1))

        'Find suit frequency

        Dim clubs, spades, diamonds, hearts As Byte
        Dim clubsCard(0), spadesCard(0), diamondsCard(0), heartsCard(0) As Card
        For Each card In fullDeck
            Select Case card._suit
                Case Is = 0
                    clubs += 1
                    insertCard(clubsCard, card)
                Case Is = 1
                    spades += 1
                    insertCard(spadesCard, card)
                Case Is = 2
                    diamonds += 1
                    insertCard(diamondsCard, card)
                Case Is = 3
                    hearts += 1
                    insertCard(heartsCard, card)
            End Select
        Next
        Dim flushDeck() As Card
        Dim flush As Boolean = False
        If clubs >= 5 Then
            flushDeck = clubsCard
            flush = True
        ElseIf spades >= 5 Then
            flushDeck = spadesCard
            flush = True
        ElseIf diamonds >= 5 Then
            flushDeck = diamondsCard
            flush = True
        ElseIf hearts >= 5 Then
            flushDeck = heartsCard
            flush = True
        End If
        If flush Then
            sortCards(flushDeck)
            If containsStraight(flushDeck) Then
                If flushDeck(flushDeck.GetUpperBound(0))._value = 12 Then
                    Return 10    'Royal flush
                Else
                    Return 9     'Straight flush
                End If
            Else
                Return 6          'flush
            End If
        End If



        Dim Values(13) As Integer
        For Each card In fullDeck
            Values(card._value) += 1
        Next

        For index = 0 To 12
            If Values(index) >= 4 Then
                Return 8            ' 4 of a kind
            End If
        Next
        Dim triples, doubles As Byte
        For index = 0 To 12
            If Values(index) = 3 Then
                triples += 1
            End If
            If Values(index) = 2 Then
                doubles += 1
            End If
        Next
        If triples > 0 And doubles > 0 Then
            Return 7                    ' full house
        End If

        sortCards(fullDeck)
        If containsStraight(fullDeck) Then
            Return 5
        End If

        If triples > 0 Then
            Return 4
        End If

        If doubles > 1 Then
            Return 3
        End If

        If doubles > 0 Then
            Return 2
        End If

        For Each card In HandCards
            If card._value >= 8 Then
                Return 1
            End If
        Next
        Return 0

        Return 0
    End Function
End Class
