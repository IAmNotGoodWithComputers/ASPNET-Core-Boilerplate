run:
	dotnet run -p Web/Web.csproj 
clean:
	rm -rf */bin/*
	rm -rf */obj/*
migrations:
	dotnet ef migrations add $(MIGRATION) --project DbAccess/DbAccess.csproj --startup-project Web/Web.csproj
