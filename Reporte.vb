Imports proyecto

Public Class Reporte

    Private usuario As Usuario
    Private libro As Libro
    Private observacion As String

    Public Property Usuario1 As Usuario
        Get
            Return usuario
        End Get
        Set(value As Usuario)
            usuario = value
        End Set
    End Property

    Public Property Libro1 As Libro
        Get
            Return libro
        End Get
        Set(value As Libro)
            libro = value
        End Set
    End Property

    Public Property Observacion1 As String
        Get
            Return observacion
        End Get
        Set(value As String)
            observacion = value
        End Set
    End Property

    Public Sub New(usuario As Usuario, libro As Libro, observacion As String)
        Me.Usuario1 = usuario
        Me.Libro1 = libro
        Me.Observacion1 = observacion
    End Sub
End Class
