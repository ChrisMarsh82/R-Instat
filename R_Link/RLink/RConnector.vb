Imports System.Diagnostics
Imports System.IO
Imports System.Threading.Tasks
Imports RDotNet

Public Class RConnector
    'TODO should be private
    Protected _rEngine As REngine
    Protected Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Public Function Connect()
        Try
            _rEngine = REngine.GetInstance()
            _rEngine.Initialize()
            Logger.Info("Succesfully connected to R")
        Catch ex As Exception
            Logger.Error(ex, "Could not connect to R")
            Return False
        End Try
        Return True
    End Function

    Public Function Diconnect()
        If _rEngine IsNot Nothing Then
            Try
                _rEngine.Dispose()
                Logger.Info("Succesfully disposed the connection to R")
            Catch ex As Exception
                Logger.Error(ex, "Could not dispose for the connection to R")
                Return False
            End Try
        End If
        Return True
    End Function

    Public Sub SetEnviromentVariables(rPath As String, rHome As String)
        Logger.Info("R Home: " & rHome)
        Logger.Info("R Path: " & rPath)
        ' Use bundled R if included
        If Directory.Exists(rHome) And Directory.Exists(rPath) Then
            Logger.Info("Using bundled R")
            REngine.SetEnvironmentVariables(rPath, rHome)
        Else
            ' Use normal process for finding local R if bundled version not included
            REngine.SetEnvironmentVariables()
        End If
    End Sub

    'ToDo shoud just be sending the Symbol
    Protected Function GetSymbol(strSymbol As String, Optional bSilent As Boolean = False) As SymbolicExpression
        Dim expTemp As SymbolicExpression = Nothing
        If _rEngine IsNot Nothing Then
            Try
                expTemp = _rEngine.GetSymbol(strSymbol)
                Logger.Info("Retrived symbol: " & strSymbol)
            Catch ex As Exception
                Logger.Error(ex, "The error occurred in attempting to retrieve: " & strSymbol)
            End Try
        End If
        Return expTemp
    End Function

    'ToDo should just be sending the script
    Public Function Evaluate(strScript As String) As Boolean
        If _rEngine IsNot Nothing Then
            Try
                _rEngine.Evaluate(strScript)
                Logger.Info("Ran script: " & strScript)
            Catch ex As Exception
                Logger.Error(ex, "The error occurred in attempting to run the following R command(s): " & strScript)
                Return False
            End Try
        End If
        Return True
    End Function
End Class
