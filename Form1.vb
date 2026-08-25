Public Class Form1

    Private showTextExample As Boolean = False


    Private Sub btnDrawText_Click(
        sender As Object,
        e As EventArgs) Handles btnDrawText.Click

        showTextExample = True

        picBox.Invalidate()

    End Sub


    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs) Handles btnClear.Click

        showTextExample = False

        picBox.Invalidate()

    End Sub


    Private Sub picBox_Paint(
        sender As Object,
        e As PaintEventArgs) Handles picBox.Paint

        If Not showTextExample Then
            Return
        End If

        Dim g As Graphics = e.Graphics

        g.Clear(Color.White)

        DrawBasicText(g)

        DrawStyledText(g)

        DrawCentredText(g)

        DrawTextInRectangle(g)

    End Sub


    ' ------------------------------------------------------------
    ' Basic text
    ' ------------------------------------------------------------

    Private Sub DrawBasicText(g As Graphics)

        Using font As New Font(
            "Segoe UI",
            14,
            FontStyle.Regular)

            Using brush As New SolidBrush(Color.Black)

                g.DrawString(
                    "Hello, VB 2026!",
                    font,
                    brush,
                    20,
                    20)

            End Using

        End Using

    End Sub


    ' ------------------------------------------------------------
    ' Bold, italic, and underlined text
    ' ------------------------------------------------------------

    Private Sub DrawStyledText(g As Graphics)

        Using boldFont As New Font(
            "Arial",
            12,
            FontStyle.Bold)

            Using italicFont As New Font(
                "Arial",
                12,
                FontStyle.Italic)

                Using underlineFont As New Font(
                    "Arial",
                    12,
                    FontStyle.Underline)

                    Using brush As New SolidBrush(
                        Color.DarkBlue)

                        g.DrawString(
                            "Bold",
                            boldFont,
                            brush,
                            20,
                            60)

                        g.DrawString(
                            "Italic",
                            italicFont,
                            brush,
                            20,
                            90)

                        g.DrawString(
                            "Underline",
                            underlineFont,
                            brush,
                            20,
                            120)

                    End Using

                End Using

            End Using

        End Using

    End Sub


    ' ------------------------------------------------------------
    ' Centre text using MeasureString
    ' ------------------------------------------------------------

    Private Sub DrawCentredText(g As Graphics)

        Dim text As String =
            "Centred Title"


        Using font As New Font(
            "Segoe UI",
            16,
            FontStyle.Bold)

            Using brush As New SolidBrush(
                Color.Navy)

                Dim textSize As SizeF =
                    g.MeasureString(
                        text,
                        font)


                Dim x As Single =
                    (picBox.ClientSize.Width -
                     textSize.Width) / 2


                Dim y As Single = 170


                g.DrawString(
                    text,
                    font,
                    brush,
                    x,
                    y)

            End Using

        End Using

    End Sub


    ' ------------------------------------------------------------
    ' Centre text inside a rectangle
    ' ------------------------------------------------------------

    Private Sub DrawTextInRectangle(
        g As Graphics)

        Dim rect As New Rectangle(
            50,
            230,
            350,
            90)


        Using backgroundBrush As New SolidBrush(
            Color.SteelBlue)

            g.FillRectangle(
                backgroundBrush,
                rect)

        End Using


        Using font As New Font(
            "Segoe UI",
            12,
            FontStyle.Bold)

            Using textBrush As New SolidBrush(
                Color.White)

                Using format As New StringFormat()

                    format.Alignment =
                        StringAlignment.Center

                    format.LineAlignment =
                        StringAlignment.Center


                    g.DrawString(
                        "Horizontally and Vertically Centred",
                        font,
                        textBrush,
                        rect,
                        format)

                End Using

            End Using

        End Using

    End Sub

End Class

