namespace Semma02.Administration {
    export interface UserPermissionListRequest extends Serenity.ServiceRequest {
        UserID?: number;
        Module?: string;
        Submodule?: string;
    }
}

