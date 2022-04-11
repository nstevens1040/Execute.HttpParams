# Execute.HttpParams
Adding functionality for Execute.HttpRequest to accept a json string as input for request parameters.

## Implements JQuery-like syntax
Consider the following JQuery ajax request.
```js
var settings = {
    "url": "https://nstevens1040.github.io/Execute.HttpParams/"
    "method": "POST",
    "timeout": 0,
    "headers": {
        "Content-Type": "application/json"
    },
    "data": JSON.stringify({
        "this": "is",
        "my": "test",
        "json": "string"
    })
};
var result;
$.ajax(settings).done(function (response) {
    if (!response){
        return;
    }
    result = response;
});
```
Execute the same HTTP request in c# using the following json as input
```json
{
    "Uri": "https://nstevens1040.github.io/Execute.HttpParams/",
    "Method": "POST",
    "Headers": {
        "Content-Type": "application/json"
    },
    "ContentType": "application/x-www-form-urlencoded",
    "Body": "{\"this\": \"is\",\"my\": \"test\",\"json\": \"string\"}"
}
```
Create parameters like this
```cs
string json_input = "{\n    \"Uri\": \"https://nstevens1040.github.io/Execute.HttpParams/\",\n    \"Method\": \"POST\",\n    \"Headers\": {\n        \"Content-Type\": \"application/json\"\n    },\n    \"ContentType\": \"application/x-www-form-urlencoded\",\n    \"Body\": \"{\\\"this\\\": \\\"is\\\",\\\"my\\\": \\\"test\\\",\\\"json\\\": \\\"string\\\"}\"\n}";
Execute.HttpRequest http = new Execute.HttpRequest(json_input);
```
