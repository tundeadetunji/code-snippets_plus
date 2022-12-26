Imports System.Collections.ObjectModel
Imports System.IO
Imports iNovation.Code.Desktop
Imports iNovation.Code.General

Public Class Form1

    Private directory As String
    Private directories As List(Of String)
    Private directories_paths As Dictionary(Of String, String)

    Private serializer As Serializer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        directories = New List(Of String)
        directories_paths = New Dictionary(Of String, String)

        setupUI()
    End Sub

    Private Sub setupUI()
        directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\inovation digital works\SnippetsPlus\SnippetsJson"

        Size = New Size(766, 338 + 33 + 4)

        dropSnippet.AutoCompleteMode = AutoCompleteMode.Suggest
        dropSnippet.AutoCompleteSource = AutoCompleteSource.ListItems

        dropSection.AutoCompleteMode = AutoCompleteMode.Suggest
        dropSection.AutoCompleteSource = AutoCompleteSource.ListItems

        dropGroup.AutoCompleteMode = AutoCompleteMode.Suggest
        dropGroup.AutoCompleteSource = AutoCompleteSource.ListItems

        Dim paths As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(directory, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
        BindProperty(folderPaths, paths)

        folderPaths.SelectedIndex = 0
        For i = 0 To folderPaths.Items.Count - 1
            Dim splits As List(Of String) = SplitTextInSplits(folderPaths.SelectedItem, "\", SideToReturn.AsListOfString)
            dropSection.Items.Add(splits(splits.Count - 1))
            Try
                folderPaths.SelectedIndex += 1
            Catch ex As Exception

            End Try
        Next

        textFileLocation.Text = directory
    End Sub

    Private Sub dropSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSection.SelectedIndexChanged
        Try
            dropGroup.DataSource = Nothing
            dropGroup.Items.Clear()
            dropGroup.Text = ""
            dropSnippet.DataSource = Nothing
            dropSnippet.Items.Clear()
            dropSnippet.Text = ""
            textSnippet.Text = ""

            folderPaths.SelectedIndex = dropSection.SelectedIndex
            BindProperty(fileNames, GetFiles(folderPaths.SelectedItem, FileType.json))

            fileNames.SelectedIndex = 0
            For i = 0 To fileNames.Items.Count - 1
                Dim splits As List(Of String) = SplitTextInSplits(fileNames.SelectedItem, "\", SideToReturn.AsListOfString)
                dropGroup.Items.Add(splits(splits.Count - 1))
                Try
                    fileNames.SelectedIndex += 1
                Catch ex As Exception

                End Try
            Next
            dropGroup.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Height >= 418 Then
            Timer1.Enabled = False
        End If
        Height += 5
    End Sub

    Private Sub buttonReload_Click(sender As Object, e As EventArgs) Handles buttonReload.Click
        Application.Restart()
    End Sub

    Private Sub dropGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropGroup.SelectedIndexChanged
        fileNames.SelectedIndex = dropGroup.SelectedIndex

        EnableControls({dropSection, dropGroup, dropSnippet, textSnippet}, False)
        serializer = New Serializer(ReadText(fileNames.SelectedItem))
        BindProperty(dropSnippet, serializer.keys())

        EnableControls({dropSection, dropGroup, dropSnippet, textSnippet})

        dropSnippet.Focus()
    End Sub

    Private Sub dropSnippet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSnippet.SelectedIndexChanged
        'If dropSnippet.Items.Count < 1 Or dropSection.Items.Count < 1 Then Return

        textSnippet.Text = ""
        Dim snippet As String = ""
        snippet = serializer.snippet(Content(dropSnippet))
        If snippet IsNot Nothing And snippet.Length > 0 Then
            textSnippet.Text = snippet
            Clipboard.SetText(snippet)
        End If

    End Sub

    Private Sub buttonShowFileLocation_Click(sender As Object, e As EventArgs) Handles buttonShowFileLocation.Click
        Timer1.Enabled = True
        buttonShowFileLocation.Enabled = False
    End Sub
End Class
