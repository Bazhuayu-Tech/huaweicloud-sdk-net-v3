using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V3.Model;

namespace HuaweiCloud.SDK.Iam.V3
{
    public partial class IamAsyncClient : Client
    {
        public static ClientBuilder<IamAsyncClient> NewBuilder()
        {
            return new ClientBuilder<IamAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 为委托授予所有项目服务权限
        /// </summary>
        public async Task<AssociateAgencyWithAllProjectsPermissionResponse> AssociateAgencyWithAllProjectsPermissionAsync(AssociateAgencyWithAllProjectsPermissionRequest associateAgencyWithAllProjectsPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , associateAgencyWithAllProjectsPermissionRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , associateAgencyWithAllProjectsPermissionRequest.DomainId.ToString());
            urlParam.Add("role_id" , associateAgencyWithAllProjectsPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithAllProjectsPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithAllProjectsPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为委托授予全局服务权限
        /// </summary>
        public async Task<AssociateAgencyWithDomainPermissionResponse> AssociateAgencyWithDomainPermissionAsync(AssociateAgencyWithDomainPermissionRequest associateAgencyWithDomainPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , associateAgencyWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("agency_id" , associateAgencyWithDomainPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithDomainPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithDomainPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为委托授予项目服务权限
        /// </summary>
        public async Task<AssociateAgencyWithProjectPermissionResponse> AssociateAgencyWithProjectPermissionAsync(AssociateAgencyWithProjectPermissionRequest associateAgencyWithProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , associateAgencyWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , associateAgencyWithProjectPermissionRequest.AgencyId.ToString());
            urlParam.Add("role_id" , associateAgencyWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, associateAgencyWithProjectPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<AssociateAgencyWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 检查委托下是否具有所有项目服务权限
        /// </summary>
        public async Task<CheckAllProjectsPermissionForAgencyResponse> CheckAllProjectsPermissionForAgencyAsync(CheckAllProjectsPermissionForAgencyRequest checkAllProjectsPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , checkAllProjectsPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , checkAllProjectsPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id" , checkAllProjectsPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkAllProjectsPermissionForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckAllProjectsPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托是否拥有全局服务权限
        /// </summary>
        public async Task<CheckDomainPermissionForAgencyResponse> CheckDomainPermissionForAgencyAsync(CheckDomainPermissionForAgencyRequest checkDomainPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , checkDomainPermissionForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id" , checkDomainPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkDomainPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkDomainPermissionForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckDomainPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托是否拥有项目服务权限
        /// </summary>
        public async Task<CheckProjectPermissionForAgencyResponse> CheckProjectPermissionForAgencyAsync(CheckProjectPermissionForAgencyRequest checkProjectPermissionForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , checkProjectPermissionForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , checkProjectPermissionForAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , checkProjectPermissionForAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, checkProjectPermissionForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<CheckProjectPermissionForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 创建委托
        /// </summary>
        public async Task<CreateAgencyResponse> CreateAgencyAsync(CreateAgencyRequest createAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyResponse>(response);
        }
        
        /// <summary>
        /// 创建委托自定义策略
        /// </summary>
        public async Task<CreateAgencyCustomPolicyResponse> CreateAgencyCustomPolicyAsync(CreateAgencyCustomPolicyRequest createAgencyCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAgencyCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAgencyCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务自定义策略
        /// </summary>
        public async Task<CreateCloudServiceCustomPolicyResponse> CreateCloudServiceCustomPolicyAsync(CreateCloudServiceCustomPolicyRequest createCloudServiceCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCloudServiceCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudServiceCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除委托
        /// </summary>
        public async Task<DeleteAgencyResponse> DeleteAgencyAsync(DeleteAgencyRequest deleteAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , deleteAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAgencyResponse>(response);
        }
        
        /// <summary>
        /// 删除自定义策略
        /// </summary>
        public async Task<DeleteCustomPolicyResponse> DeleteCustomPolicyAsync(DeleteCustomPolicyRequest deleteCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , deleteCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 添加IAM用户到用户组
        /// </summary>
        public async Task<KeystoneAddUserToGroupResponse> KeystoneAddUserToGroupAsync(KeystoneAddUserToGroupRequest keystoneAddUserToGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneAddUserToGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneAddUserToGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAddUserToGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAddUserToGroupResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予所有项目服务权限
        /// </summary>
        public async Task<KeystoneAssociateGroupWithAllProjectPermissionResponse> KeystoneAssociateGroupWithAllProjectPermissionAsync(KeystoneAssociateGroupWithAllProjectPermissionRequest keystoneAssociateGroupWithAllProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithAllProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/OS-INHERIT/domains/{domain_id}/groups/{group_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithAllProjectPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithAllProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予全局服务权限
        /// </summary>
        public async Task<KeystoneAssociateGroupWithDomainPermissionResponse> KeystoneAssociateGroupWithDomainPermissionAsync(KeystoneAssociateGroupWithDomainPermissionRequest keystoneAssociateGroupWithDomainPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneAssociateGroupWithDomainPermissionRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithDomainPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithDomainPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithDomainPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithDomainPermissionResponse>(response);
        }
        
        /// <summary>
        /// 为用户组授予项目服务权限
        /// </summary>
        public async Task<KeystoneAssociateGroupWithProjectPermissionResponse> KeystoneAssociateGroupWithProjectPermissionAsync(KeystoneAssociateGroupWithProjectPermissionRequest keystoneAssociateGroupWithProjectPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneAssociateGroupWithProjectPermissionRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneAssociateGroupWithProjectPermissionRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneAssociateGroupWithProjectPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneAssociateGroupWithProjectPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<KeystoneAssociateGroupWithProjectPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组是否拥有全局服务权限
        /// </summary>
        public async Task<KeystoneCheckDomainPermissionForGroupResponse> KeystoneCheckDomainPermissionForGroupAsync(KeystoneCheckDomainPermissionForGroupRequest keystoneCheckDomainPermissionForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneCheckDomainPermissionForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneCheckDomainPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckDomainPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckDomainPermissionForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckDomainPermissionForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组是否拥有项目服务权限
        /// </summary>
        public async Task<KeystoneCheckProjectPermissionForGroupResponse> KeystoneCheckProjectPermissionForGroupAsync(KeystoneCheckProjectPermissionForGroupRequest keystoneCheckProjectPermissionForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneCheckProjectPermissionForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneCheckProjectPermissionForGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneCheckProjectPermissionForGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckProjectPermissionForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckProjectPermissionForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户是否在用户组中
        /// </summary>
        public async Task<KeystoneCheckUserInGroupResponse> KeystoneCheckUserInGroupAsync(KeystoneCheckUserInGroupRequest keystoneCheckUserInGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneCheckUserInGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneCheckUserInGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneCheckUserInGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("HEAD",request);
            return JsonUtils.DeSerializeNull<KeystoneCheckUserInGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建用户组
        /// </summary>
        public async Task<KeystoneCreateGroupResponse> KeystoneCreateGroupAsync(KeystoneCreateGroupRequest keystoneCreateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建项目
        /// </summary>
        public async Task<KeystoneCreateProjectResponse> KeystoneCreateProjectAsync(KeystoneCreateProjectRequest keystoneCreateProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateProjectResponse>(response);
        }
        
        /// <summary>
        /// 删除用户组
        /// </summary>
        public async Task<KeystoneDeleteGroupResponse> KeystoneDeleteGroupAsync(KeystoneDeleteGroupRequest keystoneDeleteGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneDeleteGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneDeleteGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的账号详情
        /// </summary>
        public async Task<KeystoneListAuthDomainsResponse> KeystoneListAuthDomainsAsync(KeystoneListAuthDomainsRequest keystoneListAuthDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListAuthDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户可以访问的项目列表
        /// </summary>
        public async Task<KeystoneListAuthProjectsResponse> KeystoneListAuthProjectsAsync(KeystoneListAuthProjectsRequest keystoneListAuthProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListAuthProjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListAuthProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询全局服务中的用户组权限
        /// </summary>
        public async Task<KeystoneListDomainPermissionsForGroupResponse> KeystoneListDomainPermissionsForGroupAsync(KeystoneListDomainPermissionsForGroupRequest keystoneListDomainPermissionsForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneListDomainPermissionsForGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneListDomainPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListDomainPermissionsForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListDomainPermissionsForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点列表
        /// </summary>
        public async Task<KeystoneListEndpointsResponse> KeystoneListEndpointsAsync(KeystoneListEndpointsRequest keystoneListEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListEndpointsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组列表
        /// </summary>
        public async Task<KeystoneListGroupsResponse> KeystoneListGroupsAsync(KeystoneListGroupsRequest keystoneListGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询权限列表
        /// </summary>
        public async Task<KeystoneListPermissionsResponse> KeystoneListPermissionsAsync(KeystoneListPermissionsRequest keystoneListPermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListPermissionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListPermissionsResponse>(response);
        }
        
        /// <summary>
        /// 查询项目服务中的用户组权限
        /// </summary>
        public async Task<KeystoneListProjectPermissionsForGroupResponse> KeystoneListProjectPermissionsForGroupAsync(KeystoneListProjectPermissionsForGroupRequest keystoneListProjectPermissionsForGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneListProjectPermissionsForGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneListProjectPermissionsForGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectPermissionsForGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectPermissionsForGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的项目列表
        /// </summary>
        public async Task<KeystoneListProjectsResponse> KeystoneListProjectsAsync(KeystoneListProjectsRequest keystoneListProjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定IAM用户的项目列表
        /// </summary>
        public async Task<KeystoneListProjectsForUserResponse> KeystoneListProjectsForUserAsync(KeystoneListProjectsForUserRequest keystoneListProjectsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListProjectsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListProjectsForUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListProjectsForUserResponse>(response);
        }
        
        /// <summary>
        /// 查询区域列表
        /// </summary>
        public async Task<KeystoneListRegionsResponse> KeystoneListRegionsAsync(KeystoneListRegionsRequest keystoneListRegionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/regions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListRegionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListRegionsResponse>(response);
        }
        
        /// <summary>
        /// 查询服务列表
        /// </summary>
        public async Task<KeystoneListServicesResponse> KeystoneListServicesAsync(KeystoneListServicesRequest keystoneListServicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/services",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListServicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListServicesResponse>(response);
        }
        
        /// <summary>
        /// 管理员查询用户组所包含的IAM用户
        /// </summary>
        public async Task<KeystoneListUsersForGroupByAdminResponse> KeystoneListUsersForGroupByAdminAsync(KeystoneListUsersForGroupByAdminRequest keystoneListUsersForGroupByAdminRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneListUsersForGroupByAdminRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListUsersForGroupByAdminRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersForGroupByAdminResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息列表
        /// </summary>
        public async Task<KeystoneListVersionsResponse> KeystoneListVersionsAsync(KeystoneListVersionsRequest keystoneListVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<KeystoneListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组的全局服务权限
        /// </summary>
        public async Task<KeystoneRemoveDomainPermissionFromGroupResponse> KeystoneRemoveDomainPermissionFromGroupAsync(KeystoneRemoveDomainPermissionFromGroupRequest keystoneRemoveDomainPermissionFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneRemoveDomainPermissionFromGroupRequest.DomainId.ToString());
            urlParam.Add("group_id" , keystoneRemoveDomainPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveDomainPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveDomainPermissionFromGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveDomainPermissionFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组的项目服务权限
        /// </summary>
        public async Task<KeystoneRemoveProjectPermissionFromGroupResponse> KeystoneRemoveProjectPermissionFromGroupAsync(KeystoneRemoveProjectPermissionFromGroupRequest keystoneRemoveProjectPermissionFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneRemoveProjectPermissionFromGroupRequest.ProjectId.ToString());
            urlParam.Add("group_id" , keystoneRemoveProjectPermissionFromGroupRequest.GroupId.ToString());
            urlParam.Add("role_id" , keystoneRemoveProjectPermissionFromGroupRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}/groups/{group_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveProjectPermissionFromGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveProjectPermissionFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 移除用户组中的IAM用户
        /// </summary>
        public async Task<KeystoneRemoveUserFromGroupResponse> KeystoneRemoveUserFromGroupAsync(KeystoneRemoveUserFromGroupRequest keystoneRemoveUserFromGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneRemoveUserFromGroupRequest.GroupId.ToString());
            urlParam.Add("user_id" , keystoneRemoveUserFromGroupRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneRemoveUserFromGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneRemoveUserFromGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询服务目录
        /// </summary>
        public async Task<KeystoneShowCatalogResponse> KeystoneShowCatalogAsync(KeystoneShowCatalogRequest keystoneShowCatalogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/auth/catalog",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowCatalogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowCatalogResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点详情
        /// </summary>
        public async Task<KeystoneShowEndpointResponse> KeystoneShowEndpointAsync(KeystoneShowEndpointRequest keystoneShowEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_id" , keystoneShowEndpointRequest.EndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/endpoints/{endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowEndpointResponse>(response);
        }
        
        /// <summary>
        /// 查询用户组详情
        /// </summary>
        public async Task<KeystoneShowGroupResponse> KeystoneShowGroupAsync(KeystoneShowGroupRequest keystoneShowGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneShowGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询权限详情
        /// </summary>
        public async Task<KeystoneShowPermissionResponse> KeystoneShowPermissionAsync(KeystoneShowPermissionRequest keystoneShowPermissionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , keystoneShowPermissionRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowPermissionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowPermissionResponse>(response);
        }
        
        /// <summary>
        /// 查询项目详情
        /// </summary>
        public async Task<KeystoneShowProjectResponse> KeystoneShowProjectAsync(KeystoneShowProjectRequest keystoneShowProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneShowProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询区域详情
        /// </summary>
        public async Task<KeystoneShowRegionResponse> KeystoneShowRegionAsync(KeystoneShowRegionRequest keystoneShowRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("region_id" , keystoneShowRegionRequest.RegionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/regions/{region_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowRegionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowRegionResponse>(response);
        }
        
        /// <summary>
        /// 查询账号密码强度策略
        /// </summary>
        public async Task<KeystoneShowSecurityComplianceResponse> KeystoneShowSecurityComplianceAsync(KeystoneShowSecurityComplianceRequest keystoneShowSecurityComplianceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneShowSecurityComplianceRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowSecurityComplianceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceResponse>(response);
        }
        
        /// <summary>
        /// 按条件查询账号密码强度策略
        /// </summary>
        public async Task<KeystoneShowSecurityComplianceByOptionResponse> KeystoneShowSecurityComplianceByOptionAsync(KeystoneShowSecurityComplianceByOptionRequest keystoneShowSecurityComplianceByOptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , keystoneShowSecurityComplianceByOptionRequest.DomainId.ToString());
            urlParam.Add("option" , keystoneShowSecurityComplianceByOptionRequest.Option.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/domains/{domain_id}/config/security_compliance/{option}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowSecurityComplianceByOptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowSecurityComplianceByOptionResponse>(response);
        }
        
        /// <summary>
        /// 查询服务详情
        /// </summary>
        public async Task<KeystoneShowServiceResponse> KeystoneShowServiceAsync(KeystoneShowServiceRequest keystoneShowServiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_id" , keystoneShowServiceRequest.ServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/services/{service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowServiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowServiceResponse>(response);
        }
        
        /// <summary>
        /// 查询版本信息
        /// </summary>
        public async Task<KeystoneShowVersionResponse> KeystoneShowVersionAsync(KeystoneShowVersionRequest keystoneShowVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowVersionResponse>(response);
        }
        
        /// <summary>
        /// 更新用户组
        /// </summary>
        public async Task<KeystoneUpdateGroupResponse> KeystoneUpdateGroupAsync(KeystoneUpdateGroupRequest keystoneUpdateGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , keystoneUpdateGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改项目信息
        /// </summary>
        public async Task<KeystoneUpdateProjectResponse> KeystoneUpdateProjectAsync(KeystoneUpdateProjectRequest keystoneUpdateProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , keystoneUpdateProjectRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateProjectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询指定条件下的委托列表
        /// </summary>
        public async Task<ListAgenciesResponse> ListAgenciesAsync(ListAgenciesRequest listAgenciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAgenciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgenciesResponse>(response);
        }
        
        /// <summary>
        /// 查询委托下的所有项目服务权限列表
        /// </summary>
        public async Task<ListAllProjectsPermissionsForAgencyResponse> ListAllProjectsPermissionsForAgencyAsync(ListAllProjectsPermissionsForAgencyRequest listAllProjectsPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , listAllProjectsPermissionsForAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , listAllProjectsPermissionsForAgencyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listAllProjectsPermissionsForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllProjectsPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义策略列表
        /// </summary>
        public async Task<ListCustomPoliciesResponse> ListCustomPoliciesAsync(ListCustomPoliciesRequest listCustomPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listCustomPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCustomPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询全局服务中的委托权限
        /// </summary>
        public async Task<ListDomainPermissionsForAgencyResponse> ListDomainPermissionsForAgencyAsync(ListDomainPermissionsForAgencyRequest listDomainPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listDomainPermissionsForAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id" , listDomainPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listDomainPermissionsForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询项目服务中的委托权限
        /// </summary>
        public async Task<ListProjectPermissionsForAgencyResponse> ListProjectPermissionsForAgencyAsync(ListProjectPermissionsForAgencyRequest listProjectPermissionsForAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , listProjectPermissionsForAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , listProjectPermissionsForAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProjectPermissionsForAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectPermissionsForAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托下的所有项目服务权限
        /// </summary>
        public async Task<RemoveAllProjectsPermissionFromAgencyResponse> RemoveAllProjectsPermissionFromAgencyAsync(RemoveAllProjectsPermissionFromAgencyRequest removeAllProjectsPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , removeAllProjectsPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("domain_id" , removeAllProjectsPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("role_id" , removeAllProjectsPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-INHERIT/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}/inherited_to_projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeAllProjectsPermissionFromAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveAllProjectsPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托的全局服务权限
        /// </summary>
        public async Task<RemoveDomainPermissionFromAgencyResponse> RemoveDomainPermissionFromAgencyAsync(RemoveDomainPermissionFromAgencyRequest removeDomainPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , removeDomainPermissionFromAgencyRequest.DomainId.ToString());
            urlParam.Add("agency_id" , removeDomainPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeDomainPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/domains/{domain_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeDomainPermissionFromAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveDomainPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 移除委托的项目服务权限
        /// </summary>
        public async Task<RemoveProjectPermissionFromAgencyResponse> RemoveProjectPermissionFromAgencyAsync(RemoveProjectPermissionFromAgencyRequest removeProjectPermissionFromAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , removeProjectPermissionFromAgencyRequest.ProjectId.ToString());
            urlParam.Add("agency_id" , removeProjectPermissionFromAgencyRequest.AgencyId.ToString());
            urlParam.Add("role_id" , removeProjectPermissionFromAgencyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/projects/{project_id}/agencies/{agency_id}/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, removeProjectPermissionFromAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<RemoveProjectPermissionFromAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询委托详情
        /// </summary>
        public async Task<ShowAgencyResponse> ShowAgencyAsync(ShowAgencyRequest showAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , showAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }
        
        /// <summary>
        /// 查询自定义策略详情
        /// </summary>
        public async Task<ShowCustomPolicyResponse> ShowCustomPolicyAsync(ShowCustomPolicyRequest showCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , showCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询账号接口访问策略
        /// </summary>
        public async Task<ShowDomainApiAclPolicyResponse> ShowDomainApiAclPolicyAsync(ShowDomainApiAclPolicyRequest showDomainApiAclPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainApiAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDomainApiAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainApiAclPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询账号控制台访问策略
        /// </summary>
        public async Task<ShowDomainConsoleAclPolicyResponse> ShowDomainConsoleAclPolicyAsync(ShowDomainConsoleAclPolicyRequest showDomainConsoleAclPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainConsoleAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDomainConsoleAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainConsoleAclPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询账号登录策略
        /// </summary>
        public async Task<ShowDomainLoginPolicyResponse> ShowDomainLoginPolicyAsync(ShowDomainLoginPolicyRequest showDomainLoginPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainLoginPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDomainLoginPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLoginPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询账号密码策略
        /// </summary>
        public async Task<ShowDomainPasswordPolicyResponse> ShowDomainPasswordPolicyAsync(ShowDomainPasswordPolicyRequest showDomainPasswordPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainPasswordPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDomainPasswordPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainPasswordPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询账号操作保护策略
        /// </summary>
        public async Task<ShowDomainProtectPolicyResponse> ShowDomainProtectPolicyAsync(ShowDomainProtectPolicyRequest showDomainProtectPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainProtectPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDomainProtectPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainProtectPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询账号配额
        /// </summary>
        public async Task<ShowDomainQuotaResponse> ShowDomainQuotaAsync(ShowDomainQuotaRequest showDomainQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainQuotaRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showDomainQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询项目详情与状态
        /// </summary>
        public async Task<ShowProjectDetailsAndStatusResponse> ShowProjectDetailsAndStatusAsync(ShowProjectDetailsAndStatusRequest showProjectDetailsAndStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectDetailsAndStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProjectDetailsAndStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectDetailsAndStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询项目配额
        /// </summary>
        public async Task<ShowProjectQuotaResponse> ShowProjectQuotaAsync(ShowProjectQuotaRequest showProjectQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showProjectQuotaRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-QUOTA/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProjectQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectQuotaResponse>(response);
        }
        
        /// <summary>
        /// 修改委托
        /// </summary>
        public async Task<UpdateAgencyResponse> UpdateAgencyAsync(UpdateAgencyRequest updateAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_id" , updateAgencyRequest.AgencyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-AGENCY/agencies/{agency_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAgencyResponse>(response);
        }
        
        /// <summary>
        /// 修改委托自定义策略
        /// </summary>
        public async Task<UpdateAgencyCustomPolicyResponse> UpdateAgencyCustomPolicyAsync(UpdateAgencyCustomPolicyRequest updateAgencyCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateAgencyCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAgencyCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateAgencyCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务自定义策略
        /// </summary>
        public async Task<UpdateCloudServiceCustomPolicyResponse> UpdateCloudServiceCustomPolicyAsync(UpdateCloudServiceCustomPolicyRequest updateCloudServiceCustomPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("role_id" , updateCloudServiceCustomPolicyRequest.RoleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-ROLE/roles/{role_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCloudServiceCustomPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateCloudServiceCustomPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改账号接口访问策略
        /// </summary>
        public async Task<UpdateDomainApiAclPolicyResponse> UpdateDomainApiAclPolicyAsync(UpdateDomainApiAclPolicyRequest updateDomainApiAclPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainApiAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/api-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainApiAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainApiAclPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改账号控制台访问策略
        /// </summary>
        public async Task<UpdateDomainConsoleAclPolicyResponse> UpdateDomainConsoleAclPolicyAsync(UpdateDomainConsoleAclPolicyRequest updateDomainConsoleAclPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainConsoleAclPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/console-acl-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainConsoleAclPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainConsoleAclPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改账号登录策略
        /// </summary>
        public async Task<UpdateDomainLoginPolicyResponse> UpdateDomainLoginPolicyAsync(UpdateDomainLoginPolicyRequest updateDomainLoginPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainLoginPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/login-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainLoginPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainLoginPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改账号密码策略
        /// </summary>
        public async Task<UpdateDomainPasswordPolicyResponse> UpdateDomainPasswordPolicyAsync(UpdateDomainPasswordPolicyRequest updateDomainPasswordPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainPasswordPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/password-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainPasswordPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainPasswordPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改账号操作保护策略
        /// </summary>
        public async Task<UpdateDomainProtectPolicyResponse> UpdateDomainProtectPolicyAsync(UpdateDomainProtectPolicyRequest updateDomainProtectPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainProtectPolicyRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-SECURITYPOLICY/domains/{domain_id}/protect-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateDomainProtectPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainProtectPolicyResponse>(response);
        }
        
        /// <summary>
        /// 设置项目状态
        /// </summary>
        public async Task<UpdateProjectStatusResponse> UpdateProjectStatusAsync(UpdateProjectStatusRequest updateProjectStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , updateProjectStatusRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3-ext/projects/{project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateProjectStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateProjectStatusResponse>(response);
        }
        
        /// <summary>
        /// 创建永久访问密钥
        /// </summary>
        public async Task<CreatePermanentAccessKeyResponse> CreatePermanentAccessKeyAsync(CreatePermanentAccessKeyRequest createPermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 通过委托获取临时访问密钥
        /// </summary>
        public async Task<CreateTemporaryAccessKeyByAgencyResponse> CreateTemporaryAccessKeyByAgencyAsync(CreateTemporaryAccessKeyByAgencyRequest createTemporaryAccessKeyByAgencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByAgencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByAgencyResponse>(response);
        }
        
        /// <summary>
        /// 通过token获取临时访问密钥
        /// </summary>
        public async Task<CreateTemporaryAccessKeyByTokenResponse> CreateTemporaryAccessKeyByTokenAsync(CreateTemporaryAccessKeyByTokenRequest createTemporaryAccessKeyByTokenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/securitytokens",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTemporaryAccessKeyByTokenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTemporaryAccessKeyByTokenResponse>(response);
        }
        
        /// <summary>
        /// 删除指定永久访问密钥
        /// </summary>
        public async Task<DeletePermanentAccessKeyResponse> DeletePermanentAccessKeyAsync(DeletePermanentAccessKeyRequest deletePermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , deletePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 查询所有永久访问密钥
        /// </summary>
        public async Task<ListPermanentAccessKeysResponse> ListPermanentAccessKeysAsync(ListPermanentAccessKeysRequest listPermanentAccessKeysRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPermanentAccessKeysRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPermanentAccessKeysResponse>(response);
        }
        
        /// <summary>
        /// 查询指定永久访问密钥
        /// </summary>
        public async Task<ShowPermanentAccessKeyResponse> ShowPermanentAccessKeyAsync(ShowPermanentAccessKeyRequest showPermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , showPermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 修改指定永久访问密钥
        /// </summary>
        public async Task<UpdatePermanentAccessKeyResponse> UpdatePermanentAccessKeyAsync(UpdatePermanentAccessKeyRequest updatePermanentAccessKeyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("access_key" , updatePermanentAccessKeyRequest.AccessKey.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-CREDENTIAL/credentials/{access_key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePermanentAccessKeyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePermanentAccessKeyResponse>(response);
        }
        
        /// <summary>
        /// 管理员创建IAM用户（推荐）
        /// </summary>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员创建IAM用户
        /// </summary>
        public async Task<KeystoneCreateUserResponse> KeystoneCreateUserAsync(KeystoneCreateUserRequest keystoneCreateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneCreateUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<KeystoneCreateUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员删除IAM用户
        /// </summary>
        public async Task<KeystoneDeleteUserResponse> KeystoneDeleteUserAsync(KeystoneDeleteUserRequest keystoneDeleteUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneDeleteUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneDeleteUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<KeystoneDeleteUserResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户所属用户组
        /// </summary>
        public async Task<KeystoneListGroupsForUserResponse> KeystoneListGroupsForUserAsync(KeystoneListGroupsForUserRequest keystoneListGroupsForUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneListGroupsForUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListGroupsForUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListGroupsForUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员查询IAM用户列表
        /// </summary>
        public async Task<KeystoneListUsersResponse> KeystoneListUsersAsync(KeystoneListUsersRequest keystoneListUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneListUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneListUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户详情
        /// </summary>
        public async Task<KeystoneShowUserResponse> KeystoneShowUserAsync(KeystoneShowUserRequest keystoneShowUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneShowUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, keystoneShowUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<KeystoneShowUserResponse>(response);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息
        /// </summary>
        public async Task<KeystoneUpdateUserByAdminResponse> KeystoneUpdateUserByAdminAsync(KeystoneUpdateUserByAdminRequest keystoneUpdateUserByAdminRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserByAdminRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserByAdminRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<KeystoneUpdateUserByAdminResponse>(response);
        }
        
        /// <summary>
        /// 修改IAM用户密码
        /// </summary>
        public async Task<KeystoneUpdateUserPasswordResponse> KeystoneUpdateUserPasswordAsync(KeystoneUpdateUserPasswordRequest keystoneUpdateUserPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , keystoneUpdateUserPasswordRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/users/{user_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", keystoneUpdateUserPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<KeystoneUpdateUserPasswordResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户的登录保护状态信息列表
        /// </summary>
        public async Task<ListUserLoginProtectsResponse> ListUserLoginProtectsAsync(ListUserLoginProtectsRequest listUserLoginProtectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/login-protects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listUserLoginProtectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUserLoginProtectsResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户的MFA绑定信息列表
        /// </summary>
        public async Task<ListUserMfaDevicesResponse> ListUserMfaDevicesAsync(ListUserMfaDevicesRequest listUserMfaDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/virtual-mfa-devices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listUserMfaDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUserMfaDevicesResponse>(response);
        }
        
        /// <summary>
        /// 查询IAM用户详情（推荐）
        /// </summary>
        public async Task<ShowUserResponse> ShowUserAsync(ShowUserRequest showUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }
        
        /// <summary>
        /// 查询指定IAM用户的登录保护状态信息
        /// </summary>
        public async Task<ShowUserLoginProtectResponse> ShowUserLoginProtectAsync(ShowUserLoginProtectRequest showUserLoginProtectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserLoginProtectRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/login-protect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showUserLoginProtectRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserLoginProtectResponse>(response);
        }
        
        /// <summary>
        /// 查询指定IAM用户的MFA绑定信息
        /// </summary>
        public async Task<ShowUserMfaDeviceResponse> ShowUserMfaDeviceAsync(ShowUserMfaDeviceRequest showUserMfaDeviceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , showUserMfaDeviceRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-MFA/users/{user_id}/virtual-mfa-device",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showUserMfaDeviceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserMfaDeviceResponse>(response);
        }
        
        /// <summary>
        /// 管理员修改IAM用户信息（推荐）
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }
        
        /// <summary>
        /// 修改IAM用户信息（推荐）
        /// </summary>
        public async Task<UpdateUserInformationResponse> UpdateUserInformationAsync(UpdateUserInformationRequest updateUserInformationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("user_id" , updateUserInformationRequest.UserId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3.0/OS-USER/users/{user_id}/info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateUserInformationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateUserInformationResponse>(response);
        }
        
    }
}