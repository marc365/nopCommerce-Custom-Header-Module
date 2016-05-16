# nopCommerce-Custom-Header-Module

Requires a rebuild of nopCommerce.

Add CustomHeaderModule.cs to Nop.Web/Extensions/

Modify Web.Config (set modules to 'true' and add custom module)

[code]
  <system.webServer>
    <modules runAllManagedModulesForAllRequests="true">
      <add name="CustomHeaderModule" type="Nop.Web.Extensions.CustomHeaderModule"/>
[/code]
