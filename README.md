# Cars Task

CarModels

| ID (PK)       | Description   |
| ----------- | ------------ |
| 1             | Model 1       |
| 2             | Model 2       |

Cars

| ID (PK)       | OwnerId       | ModelId  | Description  |
| ----------- | ------------- | ------- | ----------- |
| 1             | 1             | 1        | Car 1        |
| 2             | 3             | 1        | Car 2        |
| 3             | 2             | 1        | Car 3        |
| 4             | 1             | 2        | Car 4        |
| 5             | 2             | 1        | Car 5        |
| 6             | 1             | 2        | Car 6        |

The tables CarModels and Cars have a connection by a foreign key on Cars.ModelId to CarModels.Id

Design a client-server application that transfers server data filtered by OwnerId to the client.

Server side:

.NET Application listening on a TCP/IP port for connection from the client app. After the client makes a request, filter the data based on the send OwnerId and send the data to the client.

Client side:

Enter the OwnerId, then connect to the server and after receiving the response display the result.
Use XML or database for storage.