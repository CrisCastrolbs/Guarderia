Public Interface ICrudTipoAlergiaRepository(Of Entity As Class)
    Function obtenerTodo() As IEnumerable(Of Entity)
    Function obtenerPorValor(value As String) As IEnumerable(Of Entity)
    Function añadir(entity As Entity) As Integer
    Function editar(entity As Entity) As Integer
    'Function Eliminar(IdTipoAlergia As Integer) As Integer

End Interface
