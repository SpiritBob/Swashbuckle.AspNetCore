Describing a Request Body
===========================

Request bodies are typically used with “create” and “update” operations (POST, PUT, PATCH). For example, when creating a resource using POST or PUT, the request body usually contains the representation of the resource to be created. OpenAPI 3.0 provides the ``requestBody`` keyword to describe request bodies.
To learn more about how request bodies are described by the OpenAPI Specification, checkout out the `OpenAPI docs here <https://swagger.io/docs/specification/describing-request-body/>`_.

When generating an ``operation`` for an action method, Swashbuckle will automatically include a ``requestBody`` if the action has a parameter or model property that is bound to the request body.

For example, given the following action method:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Controllers\UsersController.cs
        :language: csharp
        :start-at: [HttpPost]
        :end-at: public
        :dedent: 8

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Models\User.cs
        :language: csharp
        :start-at: public class User
        :lines: 1-5 
        :dedent: 4
 
Swashbuckle will generate the following requestBody:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\swagger.yaml
        :language: yaml
        :start-after: operationId: CreateUser
        :end-before: responses:
        :dedent: 6

.. note:: In addition to the ``[FromBody]`` attribute, Swashbuckle also supports parameters that are bound to form data via the ``[FromForm]`` attribute and/or ``IFormFile`` and ``IFormFileCollection`` types. See #TODO for more info.