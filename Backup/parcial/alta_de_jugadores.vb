Imports System.IO
Public Class Rb_alta_de_jugadores

    Private Sub Btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_registrar.Click
        Dim arch As FileInfo
        Dim fileName As StreamWriter
        Dim fileNameLeer As StreamReader
        Dim cadena As String
        Dim existe As Boolean
        Dim vector_datos(6) As String

        If Txt_dni.Text.Trim <> "" Then
            If IsNumeric(Txt_dni.Text) Then
                If Txt_apellido.Text.Trim <> "" Then
                    If Txt_nombre.Text.Trim <> "" Then
                        If MTB_fecha.Text.Trim <> "" Then
                            If Cmb_equipo.Text.Trim <> "" Then



                                arch = New FileInfo("datos1.txt")
                                fileNameLeer = arch.OpenText
                                existe = False
                                While fileNameLeer.EndOfStream = False
                                    cadena = fileNameLeer.ReadLine
                                    vector_datos = cadena.Split(";")
                                    If vector_datos(0) = Txt_dni.Text Then
                                        existe = True
                                    End If
                                End While
                                fileNameLeer.Close()

                                If existe Then
                                    MessageBox.Show("Ya existe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Else
                                    arch = New FileInfo("datos1.txt")
                                    fileName = arch.AppendText

                                    cadena = Txt_dni.Text
                                    cadena = cadena + ";"
                                    cadena = cadena + Txt_apellido.Text + ";"
                                    cadena = cadena + Txt_nombre.Text + ";"
                                    cadena = cadena + MTB_fecha.Text + ";"
                                    cadena = cadena + Cmb_equipo.Text + ";"
                                    cadena = cadena + Cmb_puesto.Text + ";"

                                    If Rb_disponible.Checked Then
                                        cadena = cadena + "Disponible" + ";"
                                    ElseIf Rb_enrecuperacion.Checked Then
                                        cadena = cadena + "En recuperacion" + ";"
                                    Else
                                        cadena = cadena + "Inhabilitado" + ";"
                                    End If


                                    fileName.WriteLine(cadena)
                                    fileName.Close()

                                    MessageBox.Show("Registrado con exito", "En buena hora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End If
                            Else
                                MessageBox.Show("ingrese equipo", "warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If

                        Else
                            MessageBox.Show("Ingrese fecha", "Warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Ingrese nombre", "Warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Ingrese apellido", "Warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No es numerico", "Warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else

            MessageBox.Show("Ingrese Dni ", "Warning!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub alta_de_jugadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim archivo As FileInfo
        Dim sarch As StreamReader
        Dim cadena As String
        Dim vector_datos(1) As String

        archivo = New FileInfo("equipo.TXT")
        sarch = archivo.OpenText
        While sarch.EndOfStream = False
            cadena = sarch.ReadLine
            vector_datos = cadena.Split(";")
            Cmb_equipo.Items.Add(vector_datos(0))
        End While
        sarch.Close()
        Cmb_equipo.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_equipo.SelectedIndex = 0

        archivo = New FileInfo("puesto.TXT")
        sarch = archivo.OpenText
        While sarch.EndOfStream = False
            cadena = sarch.ReadLine
            vector_datos = cadena.Split(";")
            Cmb_puesto.Items.Add(vector_datos(0))
        End While
        sarch.Close()
        Cmb_puesto.DropDownStyle = ComboBoxStyle.DropDownList
        Cmb_puesto.SelectedIndex = 0

        Rb_disponible.Checked = True
        Rb_enrecuperacion.Checked = True
        Rb_inhabilitado.Checked = True
    End Sub

   
    
  
End Class