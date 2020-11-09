
Public Interface ICrudPlatoRepository(Of Entity As Class)
    Function obtenerTodo() As IEnumerable(Of Entity)
    Function obtenerPorValor(value As String) As IEnumerable(Of Entity)
    Function obtenerPorValorMoney(value As Double) As IEnumerable(Of Entity)
    Function obtenerPorValorInt(entity As Integer) As IEnumerable(Of Entity)
    Function añadir(entity As Entity) As String
    Function editar(entity As Entity) As String

End Interface

