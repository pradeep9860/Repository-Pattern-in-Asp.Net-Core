// export const loginUrl = `/api/users/authenticate`;
// export const currentUserInfoUrl = `/api/users/GetLogedInUser`;

export const appMasterCompany_GetAllUrl = `/api/MasterCompany/GetAll?$OrderBy=NAME`;

export const appCompany_GetAllUrl = `/api/Company/GetAll?$OrderBy=NAME`;
export const appCompany_SaveUrl = `/api/Company/Save`;
export const appCompany_CheckCompany = `/api/Company/CheckCompany`;

export class UrlHelper {
  /**
   * The URL requested, before initial routing.
   */
  static readonly initialUrl = location.href;

  static getQueryParameters(): any {
    return document.location.search
      .replace(/(^\?)/, "")
      .split("&")
      .map(
        function(n) {
          return (n = n.split("=")), (this[n[0]] = n[1]), this;
        }.bind({})
      )[0];
  }
}
