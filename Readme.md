# Web API for MongoDB

A simple web API written in C# using ASP<span>.NET Core to connect to a premade MongoDB containing blogs in the following format:

![Blogs](Data/sample_blogs.png)

The application is able to do simple CRUD operations.  
For testing the [Rest-Client extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) in VSCode was used to do the http requests:

- Get the list of all blogs
- Get a specific blog using its id
- Add a blog to the database
- Update a blog
- Delete a blog

The access credentials to the specific MongoDB were hidden via the [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=linux#secret-manager).
