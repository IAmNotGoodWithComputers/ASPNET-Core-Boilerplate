# ASP.NET Core Multi-Project Boilerplate

This boilerplate might not match general best-practices but it is created with a focus on Linux. 
I found that this is the most flexible way for me to develop ASP.NET Core on a Linux Desktop to then run the
application on a Linux server.

# Key Properties

- The Database is in a separate project. This way, you can create command line projects that have full database
  access. For example to use these on cronjobs.
- One Makefile in the root handles migrations, cleanup and running the dev environment
- A lot of bloat compared to the standard template has been removed, while adding a few common needed things
- The InversionOfControl project can provide cross-project services as long as they are not defined in the webapp 
  itself.

# Things removed

- Bootstrap
- HomeController
- HSTS 
- Cookie Consent

# Things added

- Identity (without default UI)
- EF Core with SQLite

# Configuration

I didn't provide any way of using cross-project configuration. Personally, I use environment variables

# Makefile

- `make run` will run the webapp
- `make clean` will delete all the previously built binaries
- `MIGRATION=[nameofmigration] make migrations` will create a migration. This is especially helpful because
  we have the DB entities and the webapp in two separate projects. The migrations will be inside the dbaccess
  project
  
# Gitignore

The .gitignore ignores a lot of IDEs and binaries. It is adapted from 
https://github.com/dotnet/core/blob/master/.gitignore