using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ecs.V2.Model;

namespace HuaweiCloud.SDK.Ecs.V2
{
    public partial class EcsAsyncClient : Client
    {
        public static ClientBuilder<EcsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EcsAsyncClient>();
        }

        
        /// <summary>
        /// 云服务器组添加成员
        /// </summary>
        public async Task<AddServerGroupMemberResponse> AddServerGroupMemberAsync(AddServerGroupMemberRequest addServerGroupMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , addServerGroupMemberRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addServerGroupMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddServerGroupMemberResponse>(response);
        }
        
        /// <summary>
        /// 弹性云服务器挂载磁盘
        /// </summary>
        public async Task<AttachServerVolumeResponse> AttachServerVolumeAsync(AttachServerVolumeRequest attachServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , attachServerVolumeRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/attachvolume",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", attachServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AttachServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 批量添加云服务器网卡
        /// </summary>
        public async Task<BatchAddServerNicsResponse> BatchAddServerNicsAsync(BatchAddServerNicsRequest batchAddServerNicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchAddServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddServerNicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddServerNicsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加云服务器标签
        /// </summary>
        public async Task<BatchCreateServerTagsResponse> BatchCreateServerTagsAsync(BatchCreateServerTagsRequest batchCreateServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchCreateServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除云服务器网卡
        /// </summary>
        public async Task<BatchDeleteServerNicsResponse> BatchDeleteServerNicsAsync(BatchDeleteServerNicsRequest batchDeleteServerNicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerNicsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/nics/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerNicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteServerNicsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除云服务器标签
        /// </summary>
        public async Task<BatchDeleteServerTagsResponse> BatchDeleteServerTagsAsync(BatchDeleteServerTagsRequest batchDeleteServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , batchDeleteServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 批量重启云服务器
        /// </summary>
        public async Task<BatchRebootServersResponse> BatchRebootServersAsync(BatchRebootServersRequest batchRebootServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRebootServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRebootServersResponse>(response);
        }
        
        /// <summary>
        /// 批量启动云服务器
        /// </summary>
        public async Task<BatchStartServersResponse> BatchStartServersAsync(BatchStartServersRequest batchStartServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStartServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartServersResponse>(response);
        }
        
        /// <summary>
        /// 批量关闭云服务器
        /// </summary>
        public async Task<BatchStopServersResponse> BatchStopServersAsync(BatchStopServersRequest batchStopServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchStopServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopServersResponse>(response);
        }
        
        /// <summary>
        /// 切换弹性云服务器操作系统(安装Cloud init)
        /// </summary>
        public async Task<ChangeServerOsWithCloudInitResponse> ChangeServerOsWithCloudInitAsync(ChangeServerOsWithCloudInitRequest changeServerOsWithCloudInitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , changeServerOsWithCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/changeos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeServerOsWithCloudInitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeServerOsWithCloudInitResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器(按需)
        /// </summary>
        public async Task<CreatePostPaidServersResponse> CreatePostPaidServersAsync(CreatePostPaidServersRequest createPostPaidServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPostPaidServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidServersResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器组
        /// </summary>
        public async Task<CreateServerGroupResponse> CreateServerGroupAsync(CreateServerGroupRequest createServerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public async Task<CreateServersResponse> CreateServersAsync(CreateServersRequest createServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器组
        /// </summary>
        public async Task<DeleteServerGroupResponse> DeleteServerGroupAsync(DeleteServerGroupRequest deleteServerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , deleteServerGroupRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteServerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupResponse>(response);
        }
        
        /// <summary>
        /// 云服务器组删除成员
        /// </summary>
        public async Task<DeleteServerGroupMemberResponse> DeleteServerGroupMemberAsync(DeleteServerGroupMemberRequest deleteServerGroupMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id" , deleteServerGroupMemberRequest.ServerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/os-server-groups/{server_group_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServerGroupMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器指定元数据
        /// </summary>
        public async Task<DeleteServerMetadataResponse> DeleteServerMetadataAsync(DeleteServerMetadataRequest deleteServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteServerMetadataRequest.Key.ToString());
            urlParam.Add("server_id" , deleteServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteServerMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteServerMetadataResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public async Task<DeleteServersResponse> DeleteServersAsync(DeleteServersRequest deleteServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeleteServersResponse>(response);
        }
        
        /// <summary>
        /// 弹性云服务器卸载磁盘
        /// </summary>
        public async Task<DetachServerVolumeResponse> DetachServerVolumeAsync(DetachServerVolumeRequest detachServerVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , detachServerVolumeRequest.ServerId.ToString());
            urlParam.Add("volume_id" , detachServerVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/detachvolume/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, detachServerVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DetachServerVolumeResponse>(response);
        }
        
        /// <summary>
        /// 查询规格详情和规格扩展信息列表
        /// </summary>
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器规格变更支持列表
        /// </summary>
        public async Task<ListResizeFlavorsResponse> ListResizeFlavorsAsync(ListResizeFlavorsRequest listResizeFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/resize_flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listResizeFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResizeFlavorsResponse>(response);
        }
        
        /// <summary>
        /// 查询弹性云服务器磁盘信息
        /// </summary>
        public async Task<ListServerBlockDevicesResponse> ListServerBlockDevicesAsync(ListServerBlockDevicesRequest listServerBlockDevicesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerBlockDevicesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/block_device",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServerBlockDevicesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerBlockDevicesResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器网卡信息
        /// </summary>
        public async Task<ListServerInterfacesResponse> ListServerInterfacesAsync(ListServerInterfacesRequest listServerInterfacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , listServerInterfacesRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-interface",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServerInterfacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServerInterfacesResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public async Task<ListServersDetailsResponse> ListServersDetailsAsync(ListServersDetailsRequest listServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listServersDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 添加安全组
        /// </summary>
        public async Task<NovaAssociateSecurityGroupResponse> NovaAssociateSecurityGroupAsync(NovaAssociateSecurityGroupRequest novaAssociateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaAssociateSecurityGroupRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaAssociateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<NovaAssociateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建和导入SSH密钥
        /// </summary>
        public async Task<NovaCreateKeypairResponse> NovaCreateKeypairAsync(NovaCreateKeypairRequest novaCreateKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateKeypairResponse>(response);
        }
        
        /// <summary>
        /// 创建云服务器
        /// </summary>
        public async Task<NovaCreateServersResponse> NovaCreateServersAsync(NovaCreateServersRequest novaCreateServersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaCreateServersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<NovaCreateServersResponse>(response);
        }
        
        /// <summary>
        /// 删除SSH密钥
        /// </summary>
        public async Task<NovaDeleteKeypairResponse> NovaDeleteKeypairAsync(NovaDeleteKeypairRequest novaDeleteKeypairRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keypair_name" , novaDeleteKeypairRequest.KeypairName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs/{keypair_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaDeleteKeypairRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteKeypairResponse>(response);
        }
        
        /// <summary>
        /// 删除云服务器
        /// </summary>
        public async Task<NovaDeleteServerResponse> NovaDeleteServerAsync(NovaDeleteServerRequest novaDeleteServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDeleteServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaDeleteServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<NovaDeleteServerResponse>(response);
        }
        
        /// <summary>
        /// 移除安全组
        /// </summary>
        public async Task<NovaDisassociateSecurityGroupResponse> NovaDisassociateSecurityGroupAsync(NovaDisassociateSecurityGroupRequest novaDisassociateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaDisassociateSecurityGroupRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", novaDisassociateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<NovaDisassociateSecurityGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区列表
        /// </summary>
        public async Task<NovaListAvailabilityZonesResponse> NovaListAvailabilityZonesAsync(NovaListAvailabilityZonesRequest novaListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListAvailabilityZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListAvailabilityZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询SSH密钥列表
        /// </summary>
        public async Task<NovaListKeypairsResponse> NovaListKeypairsAsync(NovaListKeypairsRequest novaListKeypairsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/os-keypairs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListKeypairsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListKeypairsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定云服务器安全组列表
        /// </summary>
        public async Task<NovaListServerSecurityGroupsResponse> NovaListServerSecurityGroupsAsync(NovaListServerSecurityGroupsRequest novaListServerSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaListServerSecurityGroupsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}/os-security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListServerSecurityGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListServerSecurityGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情列表
        /// </summary>
        public async Task<NovaListServersDetailsResponse> NovaListServersDetailsAsync(NovaListServersDetailsRequest novaListServersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaListServersDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaListServersDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情
        /// </summary>
        public async Task<NovaShowServerResponse> NovaShowServerAsync(NovaShowServerRequest novaShowServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , novaShowServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/servers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, novaShowServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<NovaShowServerResponse>(response);
        }
        
        /// <summary>
        /// 重装弹性云服务器操作系统(安装Cloud-init)
        /// </summary>
        public async Task<ReinstallServerWithCloudInitResponse> ReinstallServerWithCloudInitAsync(ReinstallServerWithCloudInitRequest reinstallServerWithCloudInitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , reinstallServerWithCloudInitRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudservers/{server_id}/reinstallos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", reinstallServerWithCloudInitRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ReinstallServerWithCloudInitResponse>(response);
        }
        
        /// <summary>
        /// 一键重置弹性云服务器密码(企业项目)
        /// </summary>
        public async Task<ResetServerPasswordResponse> ResetServerPasswordAsync(ResetServerPasswordRequest resetServerPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resetServerPasswordRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-reset-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resetServerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetServerPasswordResponse>(response);
        }
        
        /// <summary>
        /// 变更云服务器规格(按需)
        /// </summary>
        public async Task<ResizePostPaidServerResponse> ResizePostPaidServerAsync(ResizePostPaidServerRequest resizePostPaidServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizePostPaidServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizePostPaidServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizePostPaidServerResponse>(response);
        }
        
        /// <summary>
        /// 变更云服务器规格
        /// </summary>
        public async Task<ResizeServerResponse> ResizeServerAsync(ResizeServerRequest resizeServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , resizeServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/{project_id}/cloudservers/{server_id}/resize",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeServerResponse>(response);
        }
        
        /// <summary>
        /// 查询是否支持一键重置密码
        /// </summary>
        public async Task<ShowResetPasswordFlagResponse> ShowResetPasswordFlagAsync(ShowResetPasswordFlagRequest showResetPasswordFlagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showResetPasswordFlagRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/os-resetpwd-flag",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showResetPasswordFlagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResetPasswordFlagResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器详情
        /// </summary>
        public async Task<ShowServerResponse> ShowServerAsync(ShowServerRequest showServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public async Task<ShowServerLimitsResponse> ShowServerLimitsAsync(ShowServerLimitsRequest showServerLimitsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/limits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerLimitsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerLimitsResponse>(response);
        }
        
        /// <summary>
        /// 获取VNC远程登录地址
        /// </summary>
        public async Task<ShowServerRemoteConsoleResponse> ShowServerRemoteConsoleAsync(ShowServerRemoteConsoleRequest showServerRemoteConsoleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerRemoteConsoleRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/remote_console",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showServerRemoteConsoleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowServerRemoteConsoleResponse>(response);
        }
        
        /// <summary>
        /// 查询云服务器标签
        /// </summary>
        public async Task<ShowServerTagsResponse> ShowServerTagsAsync(ShowServerTagsRequest showServerTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , showServerTagsRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showServerTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowServerTagsResponse>(response);
        }
        
        /// <summary>
        /// 修改云服务器
        /// </summary>
        public async Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest updateServerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateServerResponse>(response);
        }
        
        /// <summary>
        /// 更新云服务器元数据
        /// </summary>
        public async Task<UpdateServerMetadataResponse> UpdateServerMetadataAsync(UpdateServerMetadataRequest updateServerMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id" , updateServerMetadataRequest.ServerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloudservers/{server_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateServerMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateServerMetadataResponse>(response);
        }
        
        /// <summary>
        /// 查询任务的执行状态
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
    }
}