# aspnet-datasink-template
A template microservice that can receive data from a Sesam service instance.

To run locally do:

    dotnet restore
    dotnet run


To build the docker image do:

    docker build . -t a-good-name

To run the docker image:

    docker run -it -p 5000:5000 a-good-name
