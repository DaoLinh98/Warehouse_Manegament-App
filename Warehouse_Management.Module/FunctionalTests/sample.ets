;#DropDB Warehouse_ManagementEasyTest

#Application Warehouse_ManagementWin
#Application Warehouse_ManagementWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef Warehouse_ManagementWin

*Action About...
 
*Action OK

#EndIf

#IfDef Warehouse_ManagementWeb
*Action Navigation(My Details)
#EndIf
