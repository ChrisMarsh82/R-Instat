Imports NUnit.Framework
Imports R_Link

Namespace R_Link.Tests

    Public Class Tests

        <SetUp>
        Public Sub Setup()

        End Sub

        <Test>
        Public Sub Test1()
            Dim RConnection = New RConnector
            '  RConnection.SetEnviromentVariables()

            Assert.Pass()
        End Sub

    End Class

End Namespace