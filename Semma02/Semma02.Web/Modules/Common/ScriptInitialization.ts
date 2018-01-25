/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace Semma02.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Semma02');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}