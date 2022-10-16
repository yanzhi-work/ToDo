using TodoApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TodoApp.Permissions;

public class TodoAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TodoAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TodoAppPermissions.MyPermission1, L("Permission:MyPermission1"));

        var bookPermission = myGroup.AddPermission(TodoAppPermissions.Book.Default, L("Permission:Book"));
        bookPermission.AddChild(TodoAppPermissions.Book.Create, L("Permission:Create"));
        bookPermission.AddChild(TodoAppPermissions.Book.Update, L("Permission:Update"));
        bookPermission.AddChild(TodoAppPermissions.Book.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TodoAppResource>(name);
    }
}
