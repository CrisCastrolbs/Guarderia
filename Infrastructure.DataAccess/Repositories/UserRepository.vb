Imports System.Data.SqlClient
Imports Infrastructure.Common

Public Class UserRepository
    Inherits MasterRepository
    Implements IUserRepository


    'agregar nuevo usuario
    Public Function add(entity As User) As Integer Implements IGenericRepository(Of User).add
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@userName", entity.userName))
        parameters.Add(New SqlParameter("@password", entity.password))
        parameters.Add(New SqlParameter("@firstName", entity.firstName))
        parameters.Add(New SqlParameter("@lastName", entity.lastName))
        parameters.Add(New SqlParameter("@position", entity.position))
        parameters.Add(New SqlParameter("@email", entity.email))
        parameters.Add(New SqlParameter("@profile", entity.profile))
        'EJECUTAR PROCEDIMIENTO ALMACENADO (o COMANDO DE TEXTO SQL en caso que modificaste el metodo principal- ver punto (M-T) de la clase MasterRepository)
        'Y Enviar parámetros
        Return ExecuteNonQuery("addUser", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)

        '(E-C-M)
        'EJECUTAR UN COMANDO MIXTO (PROCEDIMIENTO o TEXTO)
        'return ExecuteNonQuery(
        '    "insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)",
        '    parameters,
        '    CommandType.Text)
        'Or
        ' return ExecuteNonQuery("addUser", parameters, CommandType.StoredProcedure)
    End Function

    'editar usuario
    Public Function edit(entity As User) As Integer Implements IGenericRepository(Of User).edit
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@userName", entity.userName))
        parameters.Add(New SqlParameter("@password", entity.password))
        parameters.Add(New SqlParameter("@firstName", entity.firstName))
        parameters.Add(New SqlParameter("@lastName", entity.lastName))
        parameters.Add(New SqlParameter("@position", entity.position))
        parameters.Add(New SqlParameter("@email", entity.email))
        parameters.Add(New SqlParameter("@profile", entity.profile))
        parameters.Add(New SqlParameter("@id", entity.id))
        Return ExecuteNonQuery("editUser", parameters)
    End Function

    '//obtener todos los datos de usuarios
    Public Function getAll() As IEnumerable(Of User) Implements IGenericRepository(Of User).getAll
        Dim result = ExecuteReader("selectAllUsers")
        Dim listUser = New List(Of User)
        For Each item As DataRow In result.Rows
            Dim userEntity = New User 'crear objeto usuario
            userEntity.id = Convert.ToInt32(item(0))
            userEntity.userName = item(1).ToString
            userEntity.password = item(2).ToString
            userEntity.firstName = item(3).ToString
            userEntity.lastName = item(4).ToString
            userEntity.position = item(5).ToString
            userEntity.email = item(6).ToString
            If Not IsDBNull(item(7)) Then 'cargamos la foto de perfil siempre en cuando que no sea nulo
                userEntity.profile = CType(item(7), Byte())
            End If

            'agregar entidad usuario a la lista
            listUser.Add(userEntity)
        Next
        Return listUser
    End Function

    '//buscar por valor (buscar por nombre o email del usuario)
    Public Function getByValue(value As String) As IEnumerable(Of User) Implements IGenericRepository(Of User).getByValue
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("selectUser", parameters)
        Dim listUser = New List(Of User)
        For Each item As DataRow In result.Rows
            Dim userEntity = New User 'crear objeto usuario
            userEntity.id = Convert.ToInt32(item(0))
            userEntity.userName = item(1).ToString
            userEntity.password = item(2).ToString
            userEntity.firstName = item(3).ToString
            userEntity.lastName = item(4).ToString
            userEntity.position = item(5).ToString
            userEntity.email = item(6).ToString
            If Not IsDBNull(item(7)) Then 'cargamos la foto de perfil siempre en cuando que no sea nulo
                userEntity.profile = CType(item(7), Byte())
            End If

            'agregar entidad usuario a la lista
            listUser.Add(userEntity)
        Next
        Return listUser
    End Function

    Public Function login(user As String, pass As String) As Boolean Implements IUserRepository.login
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@user", user))
        parameters.Add(New SqlParameter("@password", pass))
        Dim result = ExecuteReader("loginUser", parameters)
        If result.Rows.Count > 0 Then
            For Each item As DataRow In result.Rows
                ActiveUser.c_id = item(0)
                ActiveUser.c_userName = item(1)
                ActiveUser.c_password = item(2)
                ActiveUser.c_firstName = item(3)
                ActiveUser.c_lastName = item(4)
                ActiveUser.c_position = item(5)
                ActiveUser.c_email = item(6)
                If Not IsDBNull(item(7)) Then 'cargamos la foto de perfil siempre en cuando que no sea nulo
                    ActiveUser.c_profile = CType(item(7), Byte())
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Public Function remove(id As Integer) As Integer Implements IGenericRepository(Of User).remove
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@id", id))
        Return ExecuteNonQuery("removeUser", parameters)
    End Function
End Class
