using Playground.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Playground.Permissions
{
    public class PlaygroundPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(PlaygroundPermissions.GroupName, L("Permission:BookStore"));

            var booksPermission = bookStoreGroup.AddPermission(PlaygroundPermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(PlaygroundPermissions.Books.Create, L("Permission:Books.Create"));
            booksPermission.AddChild(PlaygroundPermissions.Books.Edit, L("Permission:Books.Edit"));
            booksPermission.AddChild(PlaygroundPermissions.Books.Delete, L("Permission:Books.Delete"));

            var authorsPermission = bookStoreGroup.AddPermission(
            PlaygroundPermissions.Authors.Default, L("Permission:Authors"));

            authorsPermission.AddChild(
                PlaygroundPermissions.Authors.Create, L("Permission:Authors.Create"));

            authorsPermission.AddChild(
                PlaygroundPermissions.Authors.Edit, L("Permission:Authors.Edit"));

            authorsPermission.AddChild(
                PlaygroundPermissions.Authors.Delete, L("Permission:Authors.Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PlaygroundResource>(name);
        }
    }
}
