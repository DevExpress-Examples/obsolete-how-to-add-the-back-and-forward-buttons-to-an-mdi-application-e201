Imports DevExpress.ExpressApp.Xpo
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace MDISolution.Win
   Partial Public Class MDISolutionWindowsFormsApplication
	   Inherits WinApplication

		Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
			args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
		End Sub
	  Public Sub New()
		 InitializeComponent()
		 DelayedViewItemsInitialization = True
	  End Sub

	  Private Sub MDISolutionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True

	  End Sub
   End Class
End Namespace