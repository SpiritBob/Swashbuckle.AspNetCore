Describing Responses
====================

In an OpenAPI document, each operation must have at least one response defined, usually a successful response. A response is defined by its HTTP status code and the data returned in the response body and/or headers. To learn more about how responses are described by the OpenAPI Specification, checkout out the `OpenAPI docs here <https://swagger.io/docs/specification/describing-responses/>`_.

By default, Swashbuckle will generate a "200" response for *all* operations. Additionally, if the action returns a response DTO then this will be used to generate a "schema" for the response body.

For example, given the following action method:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Controllers\UsersController.cs
        :language: csharp
        :start-at: [HttpGet]
        :end-at: public
        :dedent: 8

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Models\User.cs
        :language: csharp
        :start-at: public class User
        :lines: 1-5
        :dedent: 4

Swashbuckle will generate the following responses:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\swagger.yaml
        :language: yaml
        :start-after: operationId: GetUsers
        :end-before: x-operationId: GetUsers
        :dedent: 6
        
.. note:: If you need to specify a different status code and/or additional responses, or your actions return ``IActionResult`` instead of a response DTO, you can describe responses explicitly by annotating actions or controllers with the ``[ProducesResponseType]`` and/or ``[ProducesDefaultResponseType]`` attributes that ship with ASP.NET Core. See #TODO for more info.