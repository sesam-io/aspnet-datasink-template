# aspnet-datasink-template
A template microservice that can receive data from a Sesam service instance. The service listens 
on: 'http://localhost:5000/api/entities' for a JSON array of entities. The service parses the stream
and produces single entities. It is expected that this service is then extended to write those entities
to some system.

To run locally:

    dotnet restore
    dotnet run

To build the docker image:

    docker build . -t a-good-name

To run the docker image:

    docker run -it -p 5000:5000 a-good-name

Test by sending data using:

    curl --data '[{"id": "1"}, {"id":"2"}]' http://localhost:5000/api/entities
