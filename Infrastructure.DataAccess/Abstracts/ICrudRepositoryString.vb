Public Interface ICrudRepositoryString(Of Entity As Class)

    Function obtenerTodo() As IEnumerable(Of Entity)
    Function obtenerPorValor(value As String) As IEnumerable(Of Entity)
    'Function obtenerPorValorInt(value As String) As IEnumerable(Of Entity)
    Function añadir(entity As Entity) As String
    Function editar(entity As Entity) As String
    'Function Eliminar(CedulaInfante As Integer) As Integer

End Interface
