Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Imports System.ComponentModel
Imports MaterialSkin
Imports System.Threading

Public Class Form1
#Region "Variables"
    Private client As TcpClient
    Private dinero As Integer = 0
#End Region
#Region "Inicio de la aplicacion"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.LightBlue900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        'Dimenciones Form
        '592, 460
        Me.Width = 592
        Me.Height = 460
        BufferServer.ForeColor = Color.Lime
        BufferServer.BackColor = Color.Black
    End Sub
#End Region
    'Cuando la app se cierra
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Close()
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Close()
    End Sub
    Private Sub StartClient_Old()
        Try
            client = New TcpClient()
            client.Connect(IPAddress.Loopback, 3497)
            Log_("Cliente conectado al servidor.")
            LabelEstado.Text = "Estado: Conectado"
            GetInitialMoney()
            Log_("Enviando mensaje al servidor para obtener dinero inicial.", "->")
        Catch ex As Exception
            Log_("Error al conectar al servidor: " & ex.Message)
            LabelEstado.Text = "Estado: Desconectado"
        End Try
    End Sub
    Private Sub StartClient_()
        Try
            client = New TcpClient()
            client.Connect(IPAddress.Loopback, 3497)
            Log_("Cliente conectado al servidor.")
            LabelEstado.Text = "Estado: Conectado"
            GetInitialMoney()
            Log_("Enviando mensaje al servidor para obtener dinero inicial.", "->")

            Dim receiveThread As New Thread(AddressOf ReceiveMessages)
            receiveThread.IsBackground = True
            receiveThread.Start()
        Catch ex As Exception
            Log_("Error al conectar al servidor: " & ex.Message)
            LabelEstado.Text = "Estado: Desconectado"
        End Try
    End Sub
    Private Sub ReceiveMessages()
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim data(1024) As Byte
            Dim bytesRead As Integer

            While True
                bytesRead = stream.Read(data, 0, data.Length)
                Dim responseData As String = Encoding.ASCII.GetString(data, 0, bytesRead)

                If responseData.StartsWith("COINS_RECEIVED:") Then
                    Dim coinsString As String = responseData.Split(":")(1)
                    Dim coinsReceived As Integer
                    If Integer.TryParse(coinsString, coinsReceived) Then
                        dinero += coinsReceived
                        LabelMonedas.Text = "Monedas: " & dinero.ToString()
                        Log_("Se recibieron " & coinsReceived.ToString() & " monedas del servidor.", "<-")
                    Else
                        Log_("Respuesta inválida del servidor al enviar monedas.", "<-")
                    End If
                End If
            End While
        Catch ex As Exception
            Log_("Error al recibir mensajes del servidor: " & ex.Message, "<-")
        End Try
    End Sub
    Private Sub Log_(message As String, Optional direction As String = "<-")
        If BufferServer.InvokeRequired Then
            BufferServer.Invoke(Sub() BufferServer.AppendText(direction & " " & message & Environment.NewLine))
        Else
            BufferServer.AppendText(direction & " " & message & Environment.NewLine)
        End If
    End Sub
    Private Sub ClearLog_()
        BufferServer.Clear()
    End Sub
    Private Sub GetInitialMoney()
        Dim stream As NetworkStream = client.GetStream()
        Dim data As Byte() = Encoding.ASCII.GetBytes("GET_INITIAL_MONEY")
        stream.Write(data, 0, data.Length)
        Log_("Enviando mensaje al servidor para obtener dinero inicial.", "->")

        Dim responseData As String = String.Empty
        Dim bytes As Integer = stream.Read(data, 0, data.Length)
        responseData = Encoding.ASCII.GetString(data, 0, bytes)

        Integer.TryParse(responseData, dinero)
        LabelMonedas.Text = "Monedas: " & dinero.ToString()
        Log_("Actualizando la cantidad de dinero en el cliente: " & dinero.ToString(), "<-")
    End Sub
    Private Sub OpenCofre_()
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim data As Byte() = Encoding.ASCII.GetBytes("OPEN_CHEST")
            Log_("Enviando petición al servidor: OPEN_CHEST", "->")
            stream.Write(data, 0, data.Length)

            Log_("Esperando respuesta del servidor...")
            Dim responseData As String = WaitForResponse(stream)

            If responseData.StartsWith("COINS_RECEIVED:") Then
                Dim coinsString As String = responseData.Split(":")(1)
                Dim coinsReceived As Integer
                If Integer.TryParse(coinsString, coinsReceived) Then
                    dinero += coinsReceived
                    LabelMonedas.Text = "Monedas: " & dinero.ToString()
                    Log_("Se recibieron " & coinsReceived.ToString() & " monedas al abrir el cofre.", "<-")
                Else
                    Log_("Respuesta inválida del servidor al abrir el cofre.", "<-")
                End If
            Else
                Log_("Respuesta inválida del servidor al abrir el cofre.", "<-")
            End If
        Catch ex As Exception
            Log_("Error: " & ex.Message & " Error de comunicación", "<-")
        End Try
    End Sub
    Private Sub BuyCofre_()
        Try
            Dim stream As NetworkStream = client.GetStream()
            Dim data As Byte() = Encoding.ASCII.GetBytes("BUY_CHEST")
            Log_("Enviando petición al servidor: BUY_CHEST", "->")
            stream.Write(data, 0, data.Length)

            Log_("Esperando respuesta del servidor...")
            Dim responseData As String = WaitForResponse(stream)

            If responseData.StartsWith("COINS_RECEIVED:") Then
                Dim coinsString As String = responseData.Split(":")(1)
                Dim coinsReceived As Integer
                If Integer.TryParse(coinsString, coinsReceived) Then
                    dinero += coinsReceived
                    LabelMonedas.Text = "Monedas: " & dinero.ToString()
                    Log_("Compra realizada con éxito. Se añadieron " & coinsReceived.ToString() & " monedas.", "<-")
                Else
                    Log_("Respuesta inválida del servidor al realizar la compra.", "<-")
                End If
            ElseIf responseData = "INSUFFICIENT_FUNDS" Then
                Log_("Error: Fondos insuficientes para realizar la compra.", "<-")
            Else
                Log_("Error: " & responseData, "<-")
            End If
        Catch ex As Exception
            Log_("Error: " & ex.Message & " Error de comunicación", "<-")
        End Try
    End Sub
    Private Function WaitForResponse(stream As NetworkStream) As String
        Log_("WaitForResponse")
        Dim responseData As New StringBuilder()
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer

        While stream.DataAvailable
            bytesRead = stream.Read(buffer, 0, buffer.Length)
            responseData.Append(Encoding.ASCII.GetString(buffer, 0, bytesRead))
        End While

        Log_(responseData.ToString())
        Return responseData.ToString()
    End Function
    'Botones
    Private Sub StartServer_Click(sender As Object, e As EventArgs) Handles StartServer.Click
        StartClient_()
    End Sub

    Private Sub ClearLog_Click(sender As Object, e As EventArgs) Handles ClearLog.Click
        ClearLog_()
    End Sub

    Private Sub OpenCofre_Click(sender As Object, e As EventArgs) Handles OpenCofre.Click
        OpenCofre_()
    End Sub

    Private Sub BuyCofre_Click(sender As Object, e As EventArgs) Handles BuyCofre.Click
        BuyCofre_()
    End Sub
End Class