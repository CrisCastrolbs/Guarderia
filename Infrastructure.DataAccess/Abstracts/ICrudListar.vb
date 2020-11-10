Public Interface ICrudListar(Of Entity As Class)
    Function obtenerTodo() As IEnumerable(Of Entity)
    Function obtenerPorValor(value As String) As IEnumerable(Of Entity)
    Function obtenerPorValorInt(value As Integer) As IEnumerable(Of Entity)
    Function añadir(entity As Entity) As Integer
    Function editar(entity As Entity) As Integer
    Function listar1(entity As Entity) As String
    Function listar2(entity As Entity) As String

End Interface
