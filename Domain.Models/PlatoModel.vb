Imports Infrastructure.DataAccess
Imports Infrastructure.Common
Imports Domain.ValueObjects
Imports System.ComponentModel.DataAnnotations

Public Class PlatoModel
    'Atributos
    Private _IdPlato As Integer
    Private _NombrePlato As String
    Private _Costo As Double
    Private _state As EntityState
    Private _editPlato As Boolean = False
    Private PlatoRepository As IPlatoRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdPlato As Integer
        Get
            Return _IdPlato
        End Get
        Set(value As Integer)
            _IdPlato = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Nombre de Plato")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre del Plato debe contener un mínimo de 3 caracteres.")>
    Public Property NombrePlato As String
        Get
            Return _NombrePlato
        End Get
        Set(value As String)
            _NombrePlato = value
        End Set
    End Property


    Public Property Costo As Double
        Get
            Return _Costo
        End Get
        Set(value As Double)
            _Costo = value
        End Set
    End Property

    Public Property State As EntityState
        Private Get
            Return _state
        End Get
        Set(value As EntityState)
            _state = value
        End Set
    End Property

    Public Property EditPlato As Boolean
        Private Get
            Return _editPlato
        End Get
        Set(value As Boolean)
            _editPlato = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        PlatoRepository = New PlatoRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    PlatoRepository.añadir(PlatoEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    PlatoRepository.editar(PlatoEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    infanteRepository.eliminar(CedulaInfante)
                    '    result = "Eliminado con éxito"
            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "el nombre del Plato ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result
    End Function

    Private Function PlatoEntity() As Plato 'crear objeto ->entidad usuario
        Dim PlatoObject = New Plato
        PlatoObject.IdPlato = IdPlato
        PlatoObject.NombrePlato = NombrePlato
        PlatoObject.Costo = Costo
        Return PlatoObject
    End Function

    Public Function getAllInfantes() As List(Of PlatoModel)
        Dim result = PlatoRepository.obtenerTodo()
        Dim PlatoModelList As New List(Of PlatoModel)

        For Each item As Plato In result
            PlatoModelList.Add(New PlatoModel With {
                         .IdPlato = item.IdPlato,
                         .NombrePlato = item.NombrePlato,
                         .Costo = item.Costo})
        Next
        Return PlatoModelList
    End Function

    Public Function getAPlatoByValue(value As String) As List(Of PlatoModel)
        Dim result = PlatoRepository.obtenerPorValor(value)
        Dim PlatoModelList As New List(Of PlatoModel)

        For Each item As Plato In result
            PlatoModelList.Add(New PlatoModel With {
                         .IdPlato = item.IdPlato,
                         .NombrePlato = item.NombrePlato,
                         .Costo = item.Costo})
        Next
        Return PlatoModelList
    End Function

End Class
