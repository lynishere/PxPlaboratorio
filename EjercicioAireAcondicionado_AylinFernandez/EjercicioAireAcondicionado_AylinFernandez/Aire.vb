Public Class AIRE
    ' Atributos privados
    Private _Marca As String
    Private _Frigorias As Integer
    Private _Split As Boolean
    Private _Pais As String
    Private _FrioSolo As Boolean
    Private _Temperatura As Integer
    Private _Encendido As Boolean

    ' Propiedad solo lectura para el MODELO
    Public ReadOnly Property Modelo As String
        Get
            Dim tipoFrio As String = If(_FrioSolo, "FS", "FC")
            Dim tipoSplit As String = If(_Split, "/S", "")
            Return _Marca.Substring(0, 3).ToUpper() & _Frigorias.ToString() & _Pais.Substring(0, 3).ToUpper() & tipoFrio & tipoSplit
        End Get
    End Property

    ' Constructor de la clase AIRE
    Public Sub New(marca As String, frigorias As Integer, split As Boolean, pais As String, frioSolo As Boolean)
        _Marca = marca
        _Frigorias = frigorias
        _Split = split
        _Pais = pais.ToUpper()
        _FrioSolo = frioSolo
        _Encendido = False ' Inicialmente apagado
        _Temperatura = If(_FrioSolo, 18, 18) ' Temperatura inicial mínima
    End Sub

    ' Método para encender o apagar el aire
    Public Sub Power()
        _Encendido = Not _Encendido
    End Sub

    ' Obtener el estado de encendido
    Public Function EstadoEncendido() As Boolean
        Return _Encendido
    End Function

    ' Obtener la temperatura actual
    Public Function ObtenerTemperatura() As Integer
        Return _Temperatura
    End Function

    ' Método para aumentar la temperatura sin parámetros (fijar al máximo)
    Public Sub Subir()
        If Not _Encendido Then Exit Sub ' Solo se puede modificar la temperatura si el equipo está encendido
        Dim maxTemp As Integer = If(_FrioSolo, 24, 30) ' Máximo según el tipo de aire
        If _Split Then maxTemp += 1 ' Si es Split, aumenta un grado más
        _Temperatura = maxTemp
    End Sub

    ' Método para aumentar la temperatura con parámetros
    Public Sub Subir(grados As Integer)
        If Not _Encendido Then Exit Sub ' Solo se puede modificar la temperatura si el equipo está encendido
        Dim maxTemp As Integer = If(_FrioSolo, 24, 30) ' Máximo según el tipo de aire
        If _Split Then maxTemp += 1 ' Si es Split, aumenta un grado más
        _Temperatura = Math.Min(_Temperatura + grados, maxTemp) ' No puede sobrepasar la temperatura máxima
    End Sub

    ' Método para disminuir la temperatura sin parámetros (fijar al mínimo)
    Public Sub Bajar()
        If Not _Encendido Then Exit Sub ' Solo se puede modificar la temperatura si el equipo está encendido
        Dim minTemp As Integer = If(_FrioSolo, 18, 18) ' Mínimo según el tipo de aire
        If _Split Then minTemp -= 1 ' Si es Split, baja un grado más
        _Temperatura = minTemp
    End Sub

    ' Método para disminuir la temperatura con parámetros
    Public Sub Bajar(grados As Integer)
        If Not _Encendido Then Exit Sub ' Solo se puede modificar la temperatura si el equipo está encendido
        Dim minTemp As Integer = If(_FrioSolo, 18, 18) ' Mínimo según el tipo de aire
        If _Split Then minTemp -= 1 ' Si es Split, baja un grado más
        _Temperatura = Math.Max(_Temperatura - grados, minTemp) ' No puede bajar por debajo del mínimo
    End Sub
End Class

