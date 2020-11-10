Imports System.ComponentModel.DataAnnotations
Imports Domain.ValueObjects
Imports Infrastructure.DataAccess

Public Class PagoMensualModel


    'Atributos
    Private _IdPagoMensual As Integer
    Private _MontoBaseMensual As Double
    Private _MontoComidas As Double
    Private _MontoTotal As Double
    Private _CedulaInfante As Integer
    Private _CedulaRespPago As Integer

    Private _state As EntityState
    Private _editPagoMensual As Boolean = False
    Private pagoMensualRepository As IPagoMensualRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdPagoMensual As Integer
        Get
            Return _IdPagoMensual
        End Get
        Set(value As Integer)
            _IdPagoMensual = value
        End Set
    End Property

    Public Property MontoBaseMensual As Integer
        Get
            Return _MontoBaseMensual
        End Get
        Set(value As Integer)
            _MontoBaseMensual = value
        End Set
    End Property

    Public Property MontoComidas As Integer
        Get
            Return _MontoComidas
        End Get
        Set(value As Integer)
            _MontoComidas = value
        End Set
    End Property

    Public Property MontoTotal As Integer
        Get
            Return _MontoTotal
        End Get
        Set(value As Integer)
            _MontoTotal = value
        End Set
    End Property

    Public Property CedulaInfante As Integer
        Get
            Return _CedulaInfante
        End Get
        Set(value As Integer)
            _CedulaInfante = value
        End Set
    End Property

    Public Property CedulaRespPago As Integer
        Get
            Return _CedulaRespPago
        End Get
        Set(value As Integer)
            _CedulaRespPago = value
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

    Public Property EditPagoMensual As Boolean
        Private Get
            Return _editPagoMensual
        End Get
        Set(value As Boolean)
            _editPagoMensual = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        pagoMensualRepository = New PagoMensualRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    pagoMensualRepository.añadir(pagoMensualEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    pagoMensualRepository.editar(pagoMensualEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    infanteRepository.eliminar(CedulaInfante)
                    '    result = "Eliminado con éxito"
            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "el Pago mensual ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result
    End Function

    Private Function pagoMensualEntity() As PagoMensual 'crear objeto ->entidad usuario
        Dim pagoMensualObject = New PagoMensual
        pagoMensualObject.IdPagoMensual = IdPagoMensual
        pagoMensualObject.MontoBaseMensual = MontoBaseMensual
        pagoMensualObject.MontoComidas = MontoComidas
        pagoMensualObject.MontoTotal = MontoTotal
        pagoMensualObject.CedulaInfante = CedulaInfante
        pagoMensualObject.CedulaRespPago = CedulaRespPago
        Return pagoMensualObject
    End Function

    Public Function getAllPagoMensual() As List(Of PagoMensualModel)
        Dim result = pagoMensualRepository.obtenerTodo()
        Dim pagoMensualModelList As New List(Of PagoMensualModel)

        For Each item As PagoMensual In result
            pagoMensualModelList.Add(New PagoMensualModel With {
                         .IdPagoMensual = item.IdPagoMensual,
                         .MontoBaseMensual = item.MontoBaseMensual,
                         .MontoComidas = item.MontoComidas,
                         .MontoTotal = item.MontoTotal,
                         .CedulaInfante = item.CedulaInfante,
                         .CedulaRespPago = item.CedulaRespPago})
        Next
        Return pagoMensualModelList
    End Function

    'Public Function getAPagoMensuByValue(value As String) As List(Of PagoMensualModel)
    '    Dim result = pagoMensualRepository.obtenerPorValor(value)
    '    Dim infanteModelList As New List(Of InfanteModel)

    '    For Each item As Infante In result
    '        infanteModelList.Add(New InfanteModel With {
    '                     .CedulaInfante = item.CedulaInfante,
    '                     .Nombre = item.Nombre,
    '                     .Apellido1 = item.Apellido1,
    '                     .Apellido2 = item.Apellido2,
    '                     .FechaNac = item.FechaNac,
    '                     .Sexo = item.Sexo})
    '    Next
    '    Return infanteModelList
    'End Function

    Public Function getAPagoMensualByValue2(value As Integer) As List(Of PagoMensualModel)
        Dim result = pagoMensualRepository.obtenerPorValorInt(value)
        Dim pagoMensualModelList As New List(Of PagoMensualModel)

        For Each item As PagoMensual In result
            pagoMensualModelList.Add(New PagoMensualModel With {
                         .IdPagoMensual = item.IdPagoMensual,
                         .MontoBaseMensual = item.MontoBaseMensual,
                         .MontoComidas = item.MontoComidas,
                         .MontoTotal = item.MontoTotal,
                         .CedulaInfante = item.CedulaInfante,
                         .CedulaRespPago = item.CedulaRespPago})
        Next
        Return pagoMensualModelList
    End Function
End Class
