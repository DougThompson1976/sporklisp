Option Explicit

Private comparers As Collection

Implements IComparator

Private Sub Class_Initialize()
Set comparers = New Collection
End Sub

Public Sub addComparer(incomp As IComparator)
comparers.add incomp
End Sub
'use the list of comparers to try to reach a conclusion about these guys
Private Function IComparator_compare(lhs As Variant, RHS As Variant) As Comparison
Dim comp As IComparator

For Each comp In comparers
    IComparator_compare = comp.compare(lhs, RHS)
    If IComparator_compare <> equal Then Exit For
Next comp

End Function