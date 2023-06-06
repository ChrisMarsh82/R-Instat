Namespace R_Adapter.Enum

    Public Enum OutputType
        Script = 1
        TextOutput = 2
        ImageOutput = 4
        HtmlOutput = 8
        'the other reserved numbers are for for bitwise operations
        'todo. add the <Flags()> attribute?
    End Enum

    Public Enum ExpectedOutput
        ignoreresult = 0
        tempVariable = 1
        text = 2
        graph = 3
        webBrowser = 4
    End Enum

End Namespace