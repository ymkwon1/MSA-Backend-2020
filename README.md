# MSA 2020 Databases and API

website url: <http://msa-phase1-ym.azurewebsites.net/>

## SQL database through the Query editor

![Query1](./images/query1.png)

![Query2](./images/query2.png)

These screenshots show the query editor from the azure website showing both tables for Student and Address with appropriate examples. It also shows the Address table with appropriate attributes. StudentId, Street Number, Street, Suburb, City, Postcode and Country.

## CRUD requests

There are the basic CRUD requests in both the Student and Address table, a get method, post method, put method and delete method. as seen in the Screenshot of Swagger UI showing all api endpoints

### API method that adds a new address for a student using their student ID

![Query1](./images/address.png)

to post an address we must input the student id and must also match it in the request body, the address id will be auto generated so we leave it as 0 in the request body.

### API method that changes the address of a student using his/her StudentId was also added in the StudentController

![Query2](./images/put.png)

to modify the address of a student we need both the addressId and the studentId and both must match in the request body

## Screenshot of Swagger UI showing all api endpoints

![endpoint](./images/endpoint.png)
