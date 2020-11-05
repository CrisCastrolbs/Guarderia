Imports System.Drawing.Imaging
Imports System.IO

Public MustInherit Class ConvertItem

    Public Shared Function binaryToImage(ByVal imageBytes As Byte()) As Image
        Using tempStream As MemoryStream = New MemoryStream(imageBytes, 0, imageBytes.Length)
            'Convert byte[] to Image
            tempStream.Write(imageBytes, 0, imageBytes.Length)
            Dim image As Image = Image.FromStream(tempStream, True)
            Return image
        End Using
    End Function

    Public Shared Function imageToBinary(ByVal image As Image) As Byte()
        Using tempStream As MemoryStream = New MemoryStream()
            'Convert Image to byte[]
            image.Save(tempStream, ImageFormat.Png)
            tempStream.Seek(0, SeekOrigin.Begin)
            Dim imageBytes As Byte() = tempStream.ToArray()
            Return imageBytes
        End Using
    End Function
End Class
