PomeloMySqlError

Demo and issue when migrations for multiple contexts.

Because the healthcheck isn't perfect, sometimes the first run will fail because it can't connect to the mysql server.


## Migrations were Added ##

Add-Migration -Name "Renamed board_position.name to board_position.position_name" -OutputDir Migrations\OneDb -Context DataAccess.Contexts.OneContext -StartupProject PomeloMySqlError.Web

Add-Migration -Name "Initial Setup" -OutputDir Migrations\TwoDb -Context DataAccess.Contexts.TwoContext -StartupProject PomeloMySqlError.Web
