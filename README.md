IMTTech Coding Test
===================

This test requires you to build an API that manages accounts using the provided controller in this project.

1. You must use .NET Core and C#.
2. The API should be a ASP.NET Core Web API project.
3. The API should consume and return data as JSON.
4. You do not need to consider any security implications like using HTTPS or attempting to provide any Authorization/Authentication.
5. You do not need any persistent storage. Please use in-memory collection.


Specification
-------------
Develop an API that exposes one RESTful endpoint. This endpoint should provide standard CRUD functionality for Accounts.


### Account Object Schema

An Account class has been defined in `Models\Account.cs` file.

| Field Name | Description                                                          | Type   | Length |
| ---------- | -------------------------------------------------------------------- | ------ | ------ |
| Id         | Unique identifier.                                                   | Int32  |        |
| Code       | 6-digit Account Code.                                                | String | 6      |
| Name       | Account Name.                                                        | String | 100    |
| Type       | Type of Account. Possible values: "Asset", "Expense", "Revenue"      | String |        |


URL Formats
-----------

#### 1. Returns an array of Accounts
Method: **GET**

URL:
```
/api/account
```

Request Body:
```
```

Response Body:
```
[
  {
    "id": 1,
    "code": "100001",
    "name": "Account One",
    "type": "Asset"
  },
  {
    "id": 2,
    "code": "100002",
    "name": "Account Two",
    "type": "Revenue"
  }
]
```


#### 2. Creates an Account
Method: **POST**

URL:
```
/api/account
```

Request Body:
```
{
  "id": 1,
  "code": "100001",
  "name": "Account One",
  "type": "Asset"
}
```

Response Body:
```
```


#### 3. Gets an Account
Method: **GET**

URL:
```
/api/account/{id}
```

Request Body:
```
```

Response Body:
```
{
  "id": 1,
  "code": "100001",
  "name": "Account One",
  "type": "Asset"
}
```


#### 4. Updates an Account
Method: **PUT**

URL:
```
/api/account/{id}
```

Request Body:
```
{
  "id": 1,
  "code": "100001",
  "name": "Account One",
  "type": "Asset"
}
```

Response Body:
```
```


#### 5. Deletes an Account
Method: **DELETE**

URL:
```
/api/account/{id}
```

Request Body:
```
```

Response Body:
```
```


Bonus Tasks
-----------
These are optional tasks. Completing any of these would be an added bonus.

1. Swagger has been enabled in this project. Update the code so that Swagger shows the correct Example Value and Schema for each URLs.
2. Make use of Data Repository pattern to isolate the storage of Account objects from Controller.
3. Upon completing bonus task 2, make use of Dependency Injection in ASP.NET Core to inject Data Repository object into Controller.


Evaulation of Result
--------------------
Your code will be evaluated based on the following points:

- All the URLs can function correctly.
- Clear and concise use of classes and variable names.
- Code cleaniness.
