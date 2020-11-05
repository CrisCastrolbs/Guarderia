Public Interface IUserRepository
    Inherits IGenericRepository(Of User)
    Function login(user As String, pass As String) As Boolean
End Interface
