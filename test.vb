   Private Sub FindValueFromDropDownList(ByVal Text As String)
       Dim selectedValue As String = String.Empty

       ' Durchsuche die DropDownList Items
       For Each item As ListItem In ddlColorList.Items
           If item.Text = Text Then
               selectedValue = item.Value
               Exit For
           End If
       Next

       Dim PassenderValue As String = selectedValue

   End Sub