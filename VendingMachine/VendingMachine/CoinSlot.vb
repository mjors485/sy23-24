Public Class CoinSlot
    Public Event CoinReturnEvent(n As Integer,
                                 di As Integer,
                                 q As Integer,
                                 dol As Integer)
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property quarters As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = (nickels * 0.05) +
                (dimes * 0.1) +
                (quarters * 0.25) +
                (dollars)
            Return _total
        End Get
    End Property
    Public Sub InsertNickel()
        nickels += 1
    End Sub
    Public Sub InsertDime()
        dimes += 1
    End Sub
    Public Sub InsertQuarter()
        quarters += 1
    End Sub
    Public Sub InsertDollar()
        dollars += 1
    End Sub
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(nickels,
                                   dimes,
                                   quarters,
                                   dollars)
        nickels = 0
        dimes = 0
        quarters = 0
        dollars = 0
    End Sub
    Public Sub Buy(p As ProductControl)
        If p.ProductCount > 0 And
            p.ProductPrice <= _total Then
            _total = _total - p.ProductPrice
            p.Buy()
            CoinReturn()
            nickels = _total / 0.05
            dimes = 0
            quarters = 0
            dollars = 0
        End If
    End Sub
End Class
