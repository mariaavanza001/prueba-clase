Public Class persona
    Private nombre As String
    Private edad As Integer

    Public Sub New(nombre As String, edad As Integer)
        Me.nombre = nombre
        Me.edad = edad
    End Sub
    Public Sub getnombre(nom As String)
        Me.nombre = nom
    End Sub
    Public Sub getedad(ed As Integer)
        Me.nombre = ed
    End Sub
    Function setnom() As String
        Return Me.nombre
    End Function
    Function setedad() As Integer
        Return Me.edad
    End Function
End Class
