<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UserDataSet1 = New online_shop.userDataSet()
        Me.LoginTableAdapter1 = New online_shop.userDataSetTableAdapters.loginTableAdapter()
        Me.TableAdapterManager1 = New online_shop.userDataSetTableAdapters.TableAdapterManager()
        Me.UserDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UserDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataSet1
        '
        Me.UserDataSet1.DataSetName = "userDataSet"
        Me.UserDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableAdapter1
        '
        Me.LoginTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.loginTableAdapter = Me.LoginTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = online_shop.userDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserDataSet1BindingSource
        '
        Me.UserDataSet1BindingSource.DataSource = Me.UserDataSet1
        Me.UserDataSet1BindingSource.Position = 0
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.UserDataSet1BindingSource
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UserDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDataSet1 As userDataSet
    Friend WithEvents LoginTableAdapter1 As userDataSetTableAdapters.loginTableAdapter
    Friend WithEvents TableAdapterManager1 As userDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents UserDataSet1BindingSource As BindingSource
End Class
