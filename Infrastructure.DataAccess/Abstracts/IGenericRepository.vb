Public Interface IGenericRepository(Of Entity As Class)
    Function getAll() As IEnumerable(Of Entity)
    Function getByValue(value As String) As IEnumerable(Of Entity)
    Function add(entity As Entity) As Integer
    Function edit(entity As Entity) As Integer
    Function remove(id As Integer) As Integer
End Interface
