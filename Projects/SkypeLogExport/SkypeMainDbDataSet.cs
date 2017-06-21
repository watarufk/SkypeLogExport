namespace SkypeLogExport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Linq.Mapping;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [Table(Name = "DbMeta")]
    [DataContract]
    public class DbMetaRecord
    {
        [Column(Name = "key", IsPrimaryKey = true)]
        [DataMember, Required]
        public string key { get; set; }
        [Column(Name = "value")]
        [DataMember]
        public string @value { get; set; }
    }

    [Table(Name = "AppSchemaVersion")]
    [DataContract]
    public class AppSchemaVersionRecord
    {
        [Column(Name = "ClientVersion", CanBeNull = false)]
        [DataMember, Required]
        public string ClientVersion { get; set; }
        [Column(Name = "SQLiteSchemaVersion", CanBeNull = false)]
        [DataMember, Required]
        public Int64 SQLiteSchemaVersion { get; set; }
        [Column(Name = "SchemaUpdateType", CanBeNull = false)]
        [DataMember, Required]
        public Int64 SchemaUpdateType { get; set; }
    }

    [Table(Name = "Contacts")]
    [DataContract]
    public class ContactsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "skypename")]
        [DataMember]
        public string skypename { get; set; }
        [Column(Name = "pstnnumber")]
        [DataMember]
        public string pstnnumber { get; set; }
        [Column(Name = "aliases")]
        [DataMember]
        public string aliases { get; set; }
        [Column(Name = "fullname")]
        [DataMember]
        public string fullname { get; set; }
        [Column(Name = "birthday")]
        [DataMember]
        public Int64? birthday { get; set; }
        [Column(Name = "gender")]
        [DataMember]
        public Int64? gender { get; set; }
        [Column(Name = "languages")]
        [DataMember]
        public string languages { get; set; }
        [Column(Name = "country")]
        [DataMember]
        public string country { get; set; }
        [Column(Name = "province")]
        [DataMember]
        public string province { get; set; }
        [Column(Name = "city")]
        [DataMember]
        public string city { get; set; }
        [Column(Name = "phone_home")]
        [DataMember]
        public string phone_home { get; set; }
        [Column(Name = "phone_office")]
        [DataMember]
        public string phone_office { get; set; }
        [Column(Name = "phone_mobile")]
        [DataMember]
        public string phone_mobile { get; set; }
        [Column(Name = "emails")]
        [DataMember]
        public string emails { get; set; }
        [Column(Name = "hashed_emails")]
        [DataMember]
        public string hashed_emails { get; set; }
        [Column(Name = "homepage")]
        [DataMember]
        public string homepage { get; set; }
        [Column(Name = "about")]
        [DataMember]
        public string about { get; set; }
        [Column(Name = "avatar_image")]
        [DataMember]
        public byte[] avatar_image { get; set; }
        [Column(Name = "mood_text")]
        [DataMember]
        public string mood_text { get; set; }
        [Column(Name = "rich_mood_text")]
        [DataMember]
        public string rich_mood_text { get; set; }
        [Column(Name = "timezone")]
        [DataMember]
        public Int64? timezone { get; set; }
        [Column(Name = "capabilities")]
        [DataMember]
        public byte[] capabilities { get; set; }
        [Column(Name = "profile_timestamp")]
        [DataMember]
        public Int64? profile_timestamp { get; set; }
        [Column(Name = "nrof_authed_buddies")]
        [DataMember]
        public Int64? nrof_authed_buddies { get; set; }
        [Column(Name = "ipcountry")]
        [DataMember]
        public string ipcountry { get; set; }
        [Column(Name = "avatar_timestamp")]
        [DataMember]
        public Int64? avatar_timestamp { get; set; }
        [Column(Name = "mood_timestamp")]
        [DataMember]
        public Int64? mood_timestamp { get; set; }
        [Column(Name = "received_authrequest")]
        [DataMember]
        public string received_authrequest { get; set; }
        [Column(Name = "authreq_timestamp")]
        [DataMember]
        public Int64? authreq_timestamp { get; set; }
        [Column(Name = "lastonline_timestamp")]
        [DataMember]
        public Int64? lastonline_timestamp { get; set; }
        [Column(Name = "availability")]
        [DataMember]
        public Int64? availability { get; set; }
        [Column(Name = "displayname")]
        [DataMember]
        public string displayname { get; set; }
        [Column(Name = "firstname")]
        [DataMember]
        public string firstname { get; set; }
        [Column(Name = "lastname")]
        [DataMember]
        public string lastname { get; set; }
        [Column(Name = "refreshing")]
        [DataMember]
        public Int64? refreshing { get; set; }
        [Column(Name = "given_authlevel")]
        [DataMember]
        public Int64? given_authlevel { get; set; }
        [Column(Name = "given_displayname")]
        [DataMember]
        public string given_displayname { get; set; }
        [Column(Name = "assigned_speeddial")]
        [DataMember]
        public string assigned_speeddial { get; set; }
        [Column(Name = "assigned_comment")]
        [DataMember]
        public string assigned_comment { get; set; }
        [Column(Name = "alertstring")]
        [DataMember]
        public string alertstring { get; set; }
        [Column(Name = "lastused_timestamp")]
        [DataMember]
        public Int64? lastused_timestamp { get; set; }
        [Column(Name = "authrequest_count")]
        [DataMember]
        public Int64? authrequest_count { get; set; }
        [Column(Name = "assigned_phone1")]
        [DataMember]
        public string assigned_phone1 { get; set; }
        [Column(Name = "assigned_phone1_label")]
        [DataMember]
        public string assigned_phone1_label { get; set; }
        [Column(Name = "assigned_phone2")]
        [DataMember]
        public string assigned_phone2 { get; set; }
        [Column(Name = "assigned_phone2_label")]
        [DataMember]
        public string assigned_phone2_label { get; set; }
        [Column(Name = "assigned_phone3")]
        [DataMember]
        public string assigned_phone3 { get; set; }
        [Column(Name = "assigned_phone3_label")]
        [DataMember]
        public string assigned_phone3_label { get; set; }
        [Column(Name = "is_mobile")]
        [DataMember]
        public Int64? is_mobile { get; set; }
        [Column(Name = "is_trusted")]
        [DataMember]
        public Int64? is_trusted { get; set; }
        [Column(Name = "buddystatus")]
        [DataMember]
        public Int64? buddystatus { get; set; }
        [Column(Name = "isauthorized")]
        [DataMember]
        public Int64? isauthorized { get; set; }
        [Column(Name = "popularity_ord")]
        [DataMember]
        public Int64? popularity_ord { get; set; }
        [Column(Name = "external_id")]
        [DataMember]
        public string external_id { get; set; }
        [Column(Name = "external_system_id")]
        [DataMember]
        public string external_system_id { get; set; }
        [Column(Name = "liveid_cid")]
        [DataMember]
        public string liveid_cid { get; set; }
        [Column(Name = "profile_json")]
        [DataMember]
        public string profile_json { get; set; }
        [Column(Name = "profile_etag")]
        [DataMember]
        public string profile_etag { get; set; }
        [Column(Name = "mutual_friend_count")]
        [DataMember]
        public Int64? mutual_friend_count { get; set; }
        [Column(Name = "isblocked")]
        [DataMember]
        public Int64? isblocked { get; set; }
        [Column(Name = "authorization_certificate")]
        [DataMember]
        public byte[] authorization_certificate { get; set; }
        [Column(Name = "certificate_send_count")]
        [DataMember]
        public Int64? certificate_send_count { get; set; }
        [Column(Name = "account_modification_serial_nr")]
        [DataMember]
        public Int64? account_modification_serial_nr { get; set; }
        [Column(Name = "saved_directory_blob")]
        [DataMember]
        public byte[] saved_directory_blob { get; set; }
        [Column(Name = "nr_of_buddies")]
        [DataMember]
        public Int64? nr_of_buddies { get; set; }
        [Column(Name = "server_synced")]
        [DataMember]
        public Int64? server_synced { get; set; }
        [Column(Name = "contactlist_track")]
        [DataMember]
        public Int64? contactlist_track { get; set; }
        [Column(Name = "last_used_networktime")]
        [DataMember]
        public Int64? last_used_networktime { get; set; }
        [Column(Name = "network_availability")]
        [DataMember]
        public Int64? network_availability { get; set; }
        [Column(Name = "authorized_time")]
        [DataMember]
        public Int64? authorized_time { get; set; }
        [Column(Name = "sent_authrequest")]
        [DataMember]
        public string sent_authrequest { get; set; }
        [Column(Name = "sent_authrequest_time")]
        [DataMember]
        public Int64? sent_authrequest_time { get; set; }
        [Column(Name = "sent_authrequest_serial")]
        [DataMember]
        public Int64? sent_authrequest_serial { get; set; }
        [Column(Name = "buddyblob")]
        [DataMember]
        public byte[] buddyblob { get; set; }
        [Column(Name = "cbl_future")]
        [DataMember]
        public byte[] cbl_future { get; set; }
        [Column(Name = "node_capabilities")]
        [DataMember]
        public Int64? node_capabilities { get; set; }
        [Column(Name = "revoked_auth")]
        [DataMember]
        public Int64? revoked_auth { get; set; }
        [Column(Name = "added_in_shared_group")]
        [DataMember]
        public Int64? added_in_shared_group { get; set; }
        [Column(Name = "in_shared_group")]
        [DataMember]
        public Int64? in_shared_group { get; set; }
        [Column(Name = "authreq_history")]
        [DataMember]
        public byte[] authreq_history { get; set; }
        [Column(Name = "profile_attachments")]
        [DataMember]
        public byte[] profile_attachments { get; set; }
        [Column(Name = "stack_version")]
        [DataMember]
        public Int64? stack_version { get; set; }
        [Column(Name = "offline_authreq_id")]
        [DataMember]
        public Int64? offline_authreq_id { get; set; }
        [Column(Name = "node_capabilities_and")]
        [DataMember]
        public Int64? node_capabilities_and { get; set; }
        [Column(Name = "authreq_crc")]
        [DataMember]
        public Int64? authreq_crc { get; set; }
        [Column(Name = "authreq_src")]
        [DataMember]
        public Int64? authreq_src { get; set; }
        [Column(Name = "pop_score")]
        [DataMember]
        public Int64? pop_score { get; set; }
        [Column(Name = "authreq_nodeinfo")]
        [DataMember]
        public byte[] authreq_nodeinfo { get; set; }
        [Column(Name = "main_phone")]
        [DataMember]
        public string main_phone { get; set; }
        [Column(Name = "unified_servants")]
        [DataMember]
        public string unified_servants { get; set; }
        [Column(Name = "phone_home_normalized")]
        [DataMember]
        public string phone_home_normalized { get; set; }
        [Column(Name = "phone_office_normalized")]
        [DataMember]
        public string phone_office_normalized { get; set; }
        [Column(Name = "phone_mobile_normalized")]
        [DataMember]
        public string phone_mobile_normalized { get; set; }
        [Column(Name = "sent_authrequest_initmethod")]
        [DataMember]
        public Int64? sent_authrequest_initmethod { get; set; }
        [Column(Name = "authreq_initmethod")]
        [DataMember]
        public Int64? authreq_initmethod { get; set; }
        [Column(Name = "verified_email")]
        [DataMember]
        public byte[] verified_email { get; set; }
        [Column(Name = "verified_company")]
        [DataMember]
        public byte[] verified_company { get; set; }
        [Column(Name = "sent_authrequest_extrasbitmask")]
        [DataMember]
        public Int64? sent_authrequest_extrasbitmask { get; set; }
        [Column(Name = "is_auto_buddy")]
        [DataMember]
        public Int64? is_auto_buddy { get; set; }
        [Column(Name = "group_membership")]
        [DataMember]
        public Int64? group_membership { get; set; }
        [Column(Name = "avatar_url")]
        [DataMember]
        public string avatar_url { get; set; }
        [Column(Name = "avatar_url_new")]
        [DataMember]
        public string avatar_url_new { get; set; }
        [Column(Name = "avatar_hiresurl")]
        [DataMember]
        public string avatar_hiresurl { get; set; }
        [Column(Name = "avatar_hiresurl_new")]
        [DataMember]
        public string avatar_hiresurl_new { get; set; }
        [Column(Name = "dirblob_last_search_time")]
        [DataMember]
        public Int64? dirblob_last_search_time { get; set; }
        [Column(Name = "extprop_seen_birthday")]
        [DataMember]
        public Int64? extprop_seen_birthday { get; set; }
        [Column(Name = "extprop_sms_target")]
        [DataMember]
        public Int64? extprop_sms_target { get; set; }
        [Column(Name = "extprop_external_data")]
        [DataMember]
        public string extprop_external_data { get; set; }
    }

    [Table(Name = "LegacyMessages")]
    [DataContract]
    public class LegacyMessagesRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
    }

    [Table(Name = "Calls")]
    [DataContract]
    public class CallsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "begin_timestamp")]
        [DataMember]
        public Int64? begin_timestamp { get; set; }
        [Column(Name = "topic")]
        [DataMember]
        public string topic { get; set; }
        [Column(Name = "is_muted")]
        [DataMember]
        public Int64? is_muted { get; set; }
        [Column(Name = "is_unseen_missed")]
        [DataMember]
        public Int64? is_unseen_missed { get; set; }
        [Column(Name = "host_identity")]
        [DataMember]
        public string host_identity { get; set; }
        [Column(Name = "is_hostless")]
        [DataMember]
        public Int64? is_hostless { get; set; }
        [Column(Name = "mike_status")]
        [DataMember]
        public Int64? mike_status { get; set; }
        [Column(Name = "duration")]
        [DataMember]
        public Int64? duration { get; set; }
        [Column(Name = "soundlevel")]
        [DataMember]
        public Int64? soundlevel { get; set; }
        [Column(Name = "access_token")]
        [DataMember]
        public string access_token { get; set; }
        [Column(Name = "active_members")]
        [DataMember]
        public Int64? active_members { get; set; }
        [Column(Name = "is_active")]
        [DataMember]
        public Int64? is_active { get; set; }
        [Column(Name = "name")]
        [DataMember]
        public string name { get; set; }
        [Column(Name = "video_disabled")]
        [DataMember]
        public Int64? video_disabled { get; set; }
        [Column(Name = "joined_existing")]
        [DataMember]
        public Int64? joined_existing { get; set; }
        [Column(Name = "server_identity")]
        [DataMember]
        public string server_identity { get; set; }
        [Column(Name = "vaa_input_status")]
        [DataMember]
        public Int64? vaa_input_status { get; set; }
        [Column(Name = "is_incoming")]
        [DataMember]
        public Int64? is_incoming { get; set; }
        [Column(Name = "is_conference")]
        [DataMember]
        public Int64? is_conference { get; set; }
        [Column(Name = "is_on_hold")]
        [DataMember]
        public Int64? is_on_hold { get; set; }
        [Column(Name = "start_timestamp")]
        [DataMember]
        public Int64? start_timestamp { get; set; }
        [Column(Name = "quality_problems")]
        [DataMember]
        public string quality_problems { get; set; }
        [Column(Name = "current_video_audience")]
        [DataMember]
        public string current_video_audience { get; set; }
        [Column(Name = "premium_video_status")]
        [DataMember]
        public Int64? premium_video_status { get; set; }
        [Column(Name = "premium_video_is_grace_period")]
        [DataMember]
        public Int64? premium_video_is_grace_period { get; set; }
        [Column(Name = "is_premium_video_sponsor")]
        [DataMember]
        public Int64? is_premium_video_sponsor { get; set; }
        [Column(Name = "premium_video_sponsor_list")]
        [DataMember]
        public string premium_video_sponsor_list { get; set; }
        [Column(Name = "technology")]
        [DataMember]
        public Int64? technology { get; set; }
        [Column(Name = "max_videoconfcall_participants")]
        [DataMember]
        public Int64? max_videoconfcall_participants { get; set; }
        [Column(Name = "optimal_remote_videos_in_conference")]
        [DataMember]
        public Int64? optimal_remote_videos_in_conference { get; set; }
        [Column(Name = "message_id")]
        [DataMember]
        public string message_id { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "thread_id")]
        [DataMember]
        public string thread_id { get; set; }
        [Column(Name = "leg_id")]
        [DataMember]
        public string leg_id { get; set; }
        [Column(Name = "conversation_type")]
        [DataMember]
        public string conversation_type { get; set; }
        [Column(Name = "datachannel_object_id")]
        [DataMember]
        public Int64? datachannel_object_id { get; set; }
        [Column(Name = "endpoint_details")]
        [DataMember]
        public string endpoint_details { get; set; }
        [Column(Name = "caller_mri_identity")]
        [DataMember]
        public string caller_mri_identity { get; set; }
        [Column(Name = "member_count_changed")]
        [DataMember]
        public Int64? member_count_changed { get; set; }
        [Column(Name = "transfer_status")]
        [DataMember]
        public Int64? transfer_status { get; set; }
        [Column(Name = "transfer_failure_reason")]
        [DataMember]
        public Int64? transfer_failure_reason { get; set; }
        [Column(Name = "old_members")]
        [DataMember]
        public byte[] old_members { get; set; }
        [Column(Name = "partner_handle")]
        [DataMember]
        public string partner_handle { get; set; }
        [Column(Name = "partner_dispname")]
        [DataMember]
        public string partner_dispname { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "failurereason")]
        [DataMember]
        public Int64? failurereason { get; set; }
        [Column(Name = "failurecode")]
        [DataMember]
        public Int64? failurecode { get; set; }
        [Column(Name = "pstn_number")]
        [DataMember]
        public string pstn_number { get; set; }
        [Column(Name = "old_duration")]
        [DataMember]
        public Int64? old_duration { get; set; }
        [Column(Name = "conf_participants")]
        [DataMember]
        public byte[] conf_participants { get; set; }
        [Column(Name = "pstn_status")]
        [DataMember]
        public string pstn_status { get; set; }
        [Column(Name = "members")]
        [DataMember]
        public byte[] members { get; set; }
        [Column(Name = "conv_dbid")]
        [DataMember]
        public Int64? conv_dbid { get; set; }
        [Column(Name = "forwarding_destination_type")]
        [DataMember]
        public string forwarding_destination_type { get; set; }
        [Column(Name = "incoming_type")]
        [DataMember]
        public string incoming_type { get; set; }
        [Column(Name = "onbehalfof_mri")]
        [DataMember]
        public string onbehalfof_mri { get; set; }
        [Column(Name = "transferor_mri")]
        [DataMember]
        public string transferor_mri { get; set; }
    }

    [Table(Name = "Accounts")]
    [DataContract]
    public class AccountsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "pwdchangestatus")]
        [DataMember]
        public Int64? pwdchangestatus { get; set; }
        [Column(Name = "logoutreason")]
        [DataMember]
        public Int64? logoutreason { get; set; }
        [Column(Name = "commitstatus")]
        [DataMember]
        public Int64? commitstatus { get; set; }
        [Column(Name = "suggested_skypename")]
        [DataMember]
        public string suggested_skypename { get; set; }
        [Column(Name = "skypeout_balance_currency")]
        [DataMember]
        public string skypeout_balance_currency { get; set; }
        [Column(Name = "skypeout_balance")]
        [DataMember]
        public Int64? skypeout_balance { get; set; }
        [Column(Name = "skypeout_precision")]
        [DataMember]
        public Int64? skypeout_precision { get; set; }
        [Column(Name = "skypein_numbers")]
        [DataMember]
        public string skypein_numbers { get; set; }
        [Column(Name = "subscriptions")]
        [DataMember]
        public string subscriptions { get; set; }
        [Column(Name = "cblsyncstatus")]
        [DataMember]
        public Int64? cblsyncstatus { get; set; }
        [Column(Name = "contactssyncstatus")]
        [DataMember]
        public Int64? contactssyncstatus { get; set; }
        [Column(Name = "offline_callforward")]
        [DataMember]
        public string offline_callforward { get; set; }
        [Column(Name = "chat_policy")]
        [DataMember]
        public Int64? chat_policy { get; set; }
        [Column(Name = "skype_call_policy")]
        [DataMember]
        public Int64? skype_call_policy { get; set; }
        [Column(Name = "pstn_call_policy")]
        [DataMember]
        public Int64? pstn_call_policy { get; set; }
        [Column(Name = "avatar_policy")]
        [DataMember]
        public Int64? avatar_policy { get; set; }
        [Column(Name = "buddycount_policy")]
        [DataMember]
        public Int64? buddycount_policy { get; set; }
        [Column(Name = "timezone_policy")]
        [DataMember]
        public Int64? timezone_policy { get; set; }
        [Column(Name = "webpresence_policy")]
        [DataMember]
        public Int64? webpresence_policy { get; set; }
        [Column(Name = "phonenumbers_policy")]
        [DataMember]
        public Int64? phonenumbers_policy { get; set; }
        [Column(Name = "voicemail_policy")]
        [DataMember]
        public Int64? voicemail_policy { get; set; }
        [Column(Name = "authrequest_policy")]
        [DataMember]
        public Int64? authrequest_policy { get; set; }
        [Column(Name = "ad_policy")]
        [DataMember]
        public Int64? ad_policy { get; set; }
        [Column(Name = "partner_optedout")]
        [DataMember]
        public string partner_optedout { get; set; }
        [Column(Name = "service_provider_info")]
        [DataMember]
        public string service_provider_info { get; set; }
        [Column(Name = "registration_timestamp")]
        [DataMember]
        public Int64? registration_timestamp { get; set; }
        [Column(Name = "nr_of_other_instances")]
        [DataMember]
        public Int64? nr_of_other_instances { get; set; }
        [Column(Name = "partner_channel_status")]
        [DataMember]
        public string partner_channel_status { get; set; }
        [Column(Name = "flamingo_xmpp_status")]
        [DataMember]
        public Int64? flamingo_xmpp_status { get; set; }
        [Column(Name = "federated_presence_policy")]
        [DataMember]
        public Int64? federated_presence_policy { get; set; }
        [Column(Name = "liveid_membername")]
        [DataMember]
        public string liveid_membername { get; set; }
        [Column(Name = "roaming_history_enabled")]
        [DataMember]
        public Int64? roaming_history_enabled { get; set; }
        [Column(Name = "cobrand_id")]
        [DataMember]
        public Int64? cobrand_id { get; set; }
        [Column(Name = "shortcircuit_sync")]
        [DataMember]
        public Int64? shortcircuit_sync { get; set; }
        [Column(Name = "signin_name")]
        [DataMember]
        public string signin_name { get; set; }
        [Column(Name = "read_receipt_optout")]
        [DataMember]
        public Int64? read_receipt_optout { get; set; }
        [Column(Name = "hidden_expression_tabs")]
        [DataMember]
        public string hidden_expression_tabs { get; set; }
        [Column(Name = "owner_under_legal_age")]
        [DataMember]
        public Int64? owner_under_legal_age { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "skypename")]
        [DataMember]
        public string skypename { get; set; }
        [Column(Name = "pstnnumber")]
        [DataMember]
        public string pstnnumber { get; set; }
        [Column(Name = "fullname")]
        [DataMember]
        public string fullname { get; set; }
        [Column(Name = "birthday")]
        [DataMember]
        public Int64? birthday { get; set; }
        [Column(Name = "gender")]
        [DataMember]
        public Int64? gender { get; set; }
        [Column(Name = "languages")]
        [DataMember]
        public string languages { get; set; }
        [Column(Name = "country")]
        [DataMember]
        public string country { get; set; }
        [Column(Name = "province")]
        [DataMember]
        public string province { get; set; }
        [Column(Name = "city")]
        [DataMember]
        public string city { get; set; }
        [Column(Name = "phone_home")]
        [DataMember]
        public string phone_home { get; set; }
        [Column(Name = "phone_office")]
        [DataMember]
        public string phone_office { get; set; }
        [Column(Name = "phone_mobile")]
        [DataMember]
        public string phone_mobile { get; set; }
        [Column(Name = "emails")]
        [DataMember]
        public string emails { get; set; }
        [Column(Name = "homepage")]
        [DataMember]
        public string homepage { get; set; }
        [Column(Name = "about")]
        [DataMember]
        public string about { get; set; }
        [Column(Name = "profile_timestamp")]
        [DataMember]
        public Int64? profile_timestamp { get; set; }
        [Column(Name = "received_authrequest")]
        [DataMember]
        public string received_authrequest { get; set; }
        [Column(Name = "displayname")]
        [DataMember]
        public string displayname { get; set; }
        [Column(Name = "refreshing")]
        [DataMember]
        public Int64? refreshing { get; set; }
        [Column(Name = "given_authlevel")]
        [DataMember]
        public Int64? given_authlevel { get; set; }
        [Column(Name = "aliases")]
        [DataMember]
        public string aliases { get; set; }
        [Column(Name = "authreq_timestamp")]
        [DataMember]
        public Int64? authreq_timestamp { get; set; }
        [Column(Name = "mood_text")]
        [DataMember]
        public string mood_text { get; set; }
        [Column(Name = "timezone")]
        [DataMember]
        public Int64? timezone { get; set; }
        [Column(Name = "nrof_authed_buddies")]
        [DataMember]
        public Int64? nrof_authed_buddies { get; set; }
        [Column(Name = "ipcountry")]
        [DataMember]
        public string ipcountry { get; set; }
        [Column(Name = "given_displayname")]
        [DataMember]
        public string given_displayname { get; set; }
        [Column(Name = "availability")]
        [DataMember]
        public Int64? availability { get; set; }
        [Column(Name = "lastonline_timestamp")]
        [DataMember]
        public Int64? lastonline_timestamp { get; set; }
        [Column(Name = "capabilities")]
        [DataMember]
        public byte[] capabilities { get; set; }
        [Column(Name = "avatar_image")]
        [DataMember]
        public byte[] avatar_image { get; set; }
        [Column(Name = "assigned_speeddial")]
        [DataMember]
        public string assigned_speeddial { get; set; }
        [Column(Name = "lastused_timestamp")]
        [DataMember]
        public Int64? lastused_timestamp { get; set; }
        [Column(Name = "authrequest_count")]
        [DataMember]
        public Int64? authrequest_count { get; set; }
        [Column(Name = "assigned_comment")]
        [DataMember]
        public string assigned_comment { get; set; }
        [Column(Name = "alertstring")]
        [DataMember]
        public string alertstring { get; set; }
        [Column(Name = "avatar_timestamp")]
        [DataMember]
        public Int64? avatar_timestamp { get; set; }
        [Column(Name = "mood_timestamp")]
        [DataMember]
        public Int64? mood_timestamp { get; set; }
        [Column(Name = "rich_mood_text")]
        [DataMember]
        public string rich_mood_text { get; set; }
        [Column(Name = "synced_email")]
        [DataMember]
        public byte[] synced_email { get; set; }
        [Column(Name = "set_availability")]
        [DataMember]
        public Int64? Set_availability { get; set; }
        [Column(Name = "options_change_future")]
        [DataMember]
        public byte[] options_change_future { get; set; }
        [Column(Name = "msa_pmn")]
        [DataMember]
        public string msa_pmn { get; set; }
        [Column(Name = "authorized_time")]
        [DataMember]
        public Int64? authorized_time { get; set; }
        [Column(Name = "sent_authrequest")]
        [DataMember]
        public string sent_authrequest { get; set; }
        [Column(Name = "sent_authrequest_time")]
        [DataMember]
        public Int64? sent_authrequest_time { get; set; }
        [Column(Name = "sent_authrequest_serial")]
        [DataMember]
        public Int64? sent_authrequest_serial { get; set; }
        [Column(Name = "buddyblob")]
        [DataMember]
        public byte[] buddyblob { get; set; }
        [Column(Name = "cbl_future")]
        [DataMember]
        public byte[] cbl_future { get; set; }
        [Column(Name = "node_capabilities")]
        [DataMember]
        public Int64? node_capabilities { get; set; }
        [Column(Name = "node_capabilities_and")]
        [DataMember]
        public Int64? node_capabilities_and { get; set; }
        [Column(Name = "revoked_auth")]
        [DataMember]
        public Int64? revoked_auth { get; set; }
        [Column(Name = "added_in_shared_group")]
        [DataMember]
        public Int64? added_in_shared_group { get; set; }
        [Column(Name = "in_shared_group")]
        [DataMember]
        public Int64? in_shared_group { get; set; }
        [Column(Name = "authreq_history")]
        [DataMember]
        public byte[] authreq_history { get; set; }
        [Column(Name = "profile_attachments")]
        [DataMember]
        public byte[] profile_attachments { get; set; }
        [Column(Name = "stack_version")]
        [DataMember]
        public Int64? stack_version { get; set; }
        [Column(Name = "offline_authreq_id")]
        [DataMember]
        public Int64? offline_authreq_id { get; set; }
        [Column(Name = "verified_email")]
        [DataMember]
        public byte[] verified_email { get; set; }
        [Column(Name = "verified_company")]
        [DataMember]
        public byte[] verified_company { get; set; }
        [Column(Name = "uses_jcs")]
        [DataMember]
        public Int64? uses_jcs { get; set; }
        [Column(Name = "forward_starttime")]
        [DataMember]
        public Int64? forward_starttime { get; set; }
    }

    [Table(Name = "Transfers")]
    [DataContract]
    public class TransfersRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "partner_handle")]
        [DataMember]
        public string partner_handle { get; set; }
        [Column(Name = "partner_dispname")]
        [DataMember]
        public string partner_dispname { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "failurereason")]
        [DataMember]
        public Int64? failurereason { get; set; }
        [Column(Name = "starttime")]
        [DataMember]
        public Int64? starttime { get; set; }
        [Column(Name = "finishtime")]
        [DataMember]
        public Int64? finishtime { get; set; }
        [Column(Name = "filepath")]
        [DataMember]
        public string filepath { get; set; }
        [Column(Name = "filename")]
        [DataMember]
        public string filename { get; set; }
        [Column(Name = "filesize")]
        [DataMember]
        public string filesize { get; set; }
        [Column(Name = "bytestransferred")]
        [DataMember]
        public string bytestransferred { get; set; }
        [Column(Name = "bytespersecond")]
        [DataMember]
        public Int64? bytespersecond { get; set; }
        [Column(Name = "chatmsg_guid")]
        [DataMember]
        public byte[] chatmsg_guid { get; set; }
        [Column(Name = "chatmsg_index")]
        [DataMember]
        public Int64? chatmsg_index { get; set; }
        [Column(Name = "convo_id")]
        [DataMember]
        public Int64? convo_id { get; set; }
        [Column(Name = "pk_id")]
        [DataMember]
        public Int64? pk_id { get; set; }
        [Column(Name = "nodeid")]
        [DataMember]
        public byte[] nodeid { get; set; }
        [Column(Name = "last_activity")]
        [DataMember]
        public Int64? last_activity { get; set; }
        [Column(Name = "flags")]
        [DataMember]
        public Int64? flags { get; set; }
        [Column(Name = "old_status")]
        [DataMember]
        public Int64? old_status { get; set; }
        [Column(Name = "old_filepath")]
        [DataMember]
        public Int64? old_filepath { get; set; }
        [Column(Name = "accepttime")]
        [DataMember]
        public Int64? accepttime { get; set; }
        [Column(Name = "parent_id")]
        [DataMember]
        public Int64? parent_id { get; set; }
        [Column(Name = "offer_send_list")]
        [DataMember]
        public string offer_send_list { get; set; }
        [Column(Name = "extprop_localfilename")]
        [DataMember]
        public string extprop_localfilename { get; set; }
        [Column(Name = "extprop_hide_from_history")]
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
        [Column(Name = "extprop_window_visible")]
        [DataMember]
        public Int64? extprop_window_visible { get; set; }
        [Column(Name = "extprop_handled_by_chat")]
        [DataMember]
        public Int64? extprop_handled_by_chat { get; set; }
    }

    [Table(Name = "Voicemails")]
    [DataContract]
    public class VoicemailsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "partner_handle")]
        [DataMember]
        public string partner_handle { get; set; }
        [Column(Name = "partner_dispname")]
        [DataMember]
        public string partner_dispname { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "failurereason")]
        [DataMember]
        public Int64? failurereason { get; set; }
        [Column(Name = "subject")]
        [DataMember]
        public string subject { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "duration")]
        [DataMember]
        public Int64? duration { get; set; }
        [Column(Name = "allowed_duration")]
        [DataMember]
        public Int64? allowed_duration { get; set; }
        [Column(Name = "playback_progress")]
        [DataMember]
        public Int64? playback_progress { get; set; }
        [Column(Name = "convo_id")]
        [DataMember]
        public Int64? convo_id { get; set; }
        [Column(Name = "chatmsg_guid")]
        [DataMember]
        public byte[] chatmsg_guid { get; set; }
        [Column(Name = "notification_id")]
        [DataMember]
        public Int64? notification_id { get; set; }
        [Column(Name = "flags")]
        [DataMember]
        public Int64? flags { get; set; }
        [Column(Name = "size")]
        [DataMember]
        public Int64? size { get; set; }
        [Column(Name = "path")]
        [DataMember]
        public string path { get; set; }
        [Column(Name = "failures")]
        [DataMember]
        public Int64? failures { get; set; }
        [Column(Name = "vflags")]
        [DataMember]
        public Int64? vflags { get; set; }
        [Column(Name = "xmsg")]
        [DataMember]
        public string xmsg { get; set; }
        [Column(Name = "extprop_hide_from_history")]
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
    }

    [Table(Name = "Chats")]
    [DataContract]
    public class ChatsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "name")]
        [DataMember]
        public string name { get; set; }
        [Column(Name = "options")]
        [DataMember]
        public Int64? options { get; set; }
        [Column(Name = "friendlyname")]
        [DataMember]
        public string friendlyname { get; set; }
        [Column(Name = "description")]
        [DataMember]
        public string description { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "activity_timestamp")]
        [DataMember]
        public Int64? activity_timestamp { get; set; }
        [Column(Name = "dialog_partner")]
        [DataMember]
        public string dialog_partner { get; set; }
        [Column(Name = "adder")]
        [DataMember]
        public string adder { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "mystatus")]
        [DataMember]
        public Int64? mystatus { get; set; }
        [Column(Name = "myrole")]
        [DataMember]
        public Int64? myrole { get; set; }
        [Column(Name = "posters")]
        [DataMember]
        public string posters { get; set; }
        [Column(Name = "participants")]
        [DataMember]
        public string participants { get; set; }
        [Column(Name = "applicants")]
        [DataMember]
        public string applicants { get; set; }
        [Column(Name = "banned_users")]
        [DataMember]
        public string banned_users { get; set; }
        [Column(Name = "name_text")]
        [DataMember]
        public string name_text { get; set; }
        [Column(Name = "topic")]
        [DataMember]
        public string topic { get; set; }
        [Column(Name = "topic_xml")]
        [DataMember]
        public string topic_xml { get; set; }
        [Column(Name = "guidelines")]
        [DataMember]
        public string guidelines { get; set; }
        [Column(Name = "picture")]
        [DataMember]
        public byte[] picture { get; set; }
        [Column(Name = "alertstring")]
        [DataMember]
        public string alertstring { get; set; }
        [Column(Name = "is_bookmarked")]
        [DataMember]
        public Int64? is_bookmarked { get; set; }
        [Column(Name = "passwordhint")]
        [DataMember]
        public string passwordhint { get; set; }
        [Column(Name = "unconsumed_suppressed_msg")]
        [DataMember]
        public Int64? unconsumed_suppressed_msg { get; set; }
        [Column(Name = "unconsumed_normal_msg")]
        [DataMember]
        public Int64? unconsumed_normal_msg { get; set; }
        [Column(Name = "unconsumed_elevated_msg")]
        [DataMember]
        public Int64? unconsumed_elevated_msg { get; set; }
        [Column(Name = "unconsumed_msg_voice")]
        [DataMember]
        public Int64? unconsumed_msg_voice { get; set; }
        [Column(Name = "activemembers")]
        [DataMember]
        public string activemembers { get; set; }
        [Column(Name = "state_data")]
        [DataMember]
        public byte[] state_data { get; set; }
        [Column(Name = "lifesigns")]
        [DataMember]
        public Int64? lifesigns { get; set; }
        [Column(Name = "last_change")]
        [DataMember]
        public Int64? last_change { get; set; }
        [Column(Name = "first_unread_message")]
        [DataMember]
        public Int64? first_unread_message { get; set; }
        [Column(Name = "pk_type")]
        [DataMember]
        public Int64? pk_type { get; set; }
        [Column(Name = "dbpath")]
        [DataMember]
        public string dbpath { get; set; }
        [Column(Name = "split_friendlyname")]
        [DataMember]
        public string split_friendlyname { get; set; }
        [Column(Name = "conv_dbid")]
        [DataMember]
        public Int64? conv_dbid { get; set; }
    }

    [Table(Name = "Messages")]
    [DataContract]
    public class MessagesRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "convo_id")]
        [DataMember]
        public Int64? convo_id { get; set; }
        [Column(Name = "chatname")]
        [DataMember]
        public string chatname { get; set; }
        [Column(Name = "author")]
        [DataMember]
        public string author { get; set; }
        [Column(Name = "from_dispname")]
        [DataMember]
        public string from_dispname { get; set; }
        [Column(Name = "author_was_live")]
        [DataMember]
        public Int64? author_was_live { get; set; }
        [Column(Name = "guid")]
        [DataMember]
        public byte[] guid { get; set; }
        [Column(Name = "dialog_partner")]
        [DataMember]
        public string dialog_partner { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "sending_status")]
        [DataMember]
        public Int64? sending_status { get; set; }
        [Column(Name = "option_bits")]
        [DataMember]
        public Int64? option_bits { get; set; }
        [Column(Name = "consumption_status")]
        [DataMember]
        public Int64? consumption_status { get; set; }
        [Column(Name = "edited_by")]
        [DataMember]
        public string edited_by { get; set; }
        [Column(Name = "edited_timestamp")]
        [DataMember]
        public Int64? edited_timestamp { get; set; }
        [Column(Name = "param_key")]
        [DataMember]
        public Int64? param_key { get; set; }
        [Column(Name = "param_value")]
        [DataMember]
        public Int64? param_value { get; set; }
        [Column(Name = "body_xml")]
        [DataMember]
        public string body_xml { get; set; }
        [Column(Name = "identities")]
        [DataMember]
        public string identities { get; set; }
        [Column(Name = "reason")]
        [DataMember]
        public string reason { get; set; }
        [Column(Name = "leavereason")]
        [DataMember]
        public Int64? leavereason { get; set; }
        [Column(Name = "participant_count")]
        [DataMember]
        public Int64? participant_count { get; set; }
        [Column(Name = "error_code")]
        [DataMember]
        public Int64? error_code { get; set; }
        [Column(Name = "chatmsg_type")]
        [DataMember]
        public Int64? chatmsg_type { get; set; }
        [Column(Name = "chatmsg_status")]
        [DataMember]
        public Int64? chatmsg_status { get; set; }
        [Column(Name = "body_is_rawxml")]
        [DataMember]
        public Int64? body_is_rawxml { get; set; }
        [Column(Name = "oldoptions")]
        [DataMember]
        public Int64? oldoptions { get; set; }
        [Column(Name = "newoptions")]
        [DataMember]
        public Int64? newoptions { get; set; }
        [Column(Name = "newrole")]
        [DataMember]
        public Int64? newrole { get; set; }
        [Column(Name = "pk_id")]
        [DataMember]
        public Int64? pk_id { get; set; }
        [Column(Name = "crc")]
        [DataMember]
        public Int64? crc { get; set; }
        [Column(Name = "remote_id")]
        [DataMember]
        public Int64? remote_id { get; set; }
        [Column(Name = "server_id")]
        [DataMember]
        public Int64? server_id { get; set; }
        [Column(Name = "call_guid")]
        [DataMember]
        public string call_guid { get; set; }
        [Column(Name = "annotation_version")]
        [DataMember]
        public Int64? annotation_version { get; set; }
        [Column(Name = "timestamp__ms")]
        [DataMember]
        public Int64? timestamp__ms { get; set; }
        [Column(Name = "language")]
        [DataMember]
        public string language { get; set; }
        [Column(Name = "bots_settings")]
        [DataMember]
        public string bots_settings { get; set; }
        [Column(Name = "reaction_thread")]
        [DataMember]
        public string reaction_thread { get; set; }
        [Column(Name = "content_flags")]
        [DataMember]
        public Int64? content_flags { get; set; }
        [Column(Name = "extprop_contact_review_date")]
        [DataMember]
        public string extprop_contact_review_date { get; set; }
        [Column(Name = "extprop_contact_received_stamp")]
        [DataMember]
        public Int64? extprop_contact_received_stamp { get; set; }
        [Column(Name = "extprop_contact_reviewed")]
        [DataMember]
        public Int64? extprop_contact_reviewed { get; set; }
    }

    [Table(Name = "ContactGroups")]
    [DataContract]
    public class ContactGroupsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "custom_group_id")]
        [DataMember]
        public Int64? custom_group_id { get; set; }
        [Column(Name = "given_displayname")]
        [DataMember]
        public string given_displayname { get; set; }
        [Column(Name = "nrofcontacts")]
        [DataMember]
        public Int64? nrofcontacts { get; set; }
        [Column(Name = "nrofcontacts_online")]
        [DataMember]
        public Int64? nrofcontacts_online { get; set; }
        [Column(Name = "given_sortorder")]
        [DataMember]
        public Int64? given_sortorder { get; set; }
        [Column(Name = "type_old")]
        [DataMember]
        public Int64? type_old { get; set; }
        [Column(Name = "proposer")]
        [DataMember]
        public string proposer { get; set; }
        [Column(Name = "description")]
        [DataMember]
        public string description { get; set; }
        [Column(Name = "associated_chat")]
        [DataMember]
        public string associated_chat { get; set; }
        [Column(Name = "abch_guid")]
        [DataMember]
        public string abch_guid { get; set; }
        [Column(Name = "members")]
        [DataMember]
        public string members { get; set; }
        [Column(Name = "cbl_id")]
        [DataMember]
        public Int64? cbl_id { get; set; }
        [Column(Name = "cbl_blob")]
        [DataMember]
        public byte[] cbl_blob { get; set; }
        [Column(Name = "fixed")]
        [DataMember]
        public Int64? @fixed { get; set; }
        [Column(Name = "keep_sharedgroup_contacts")]
        [DataMember]
        public Int64? keep_sharedgroup_contacts { get; set; }
        [Column(Name = "chats")]
        [DataMember]
        public string chats { get; set; }
        [Column(Name = "extprop_is_hidden")]
        [DataMember]
        public Int64? extprop_is_hidden { get; set; }
        [Column(Name = "extprop_sortorder_value")]
        [DataMember]
        public Int64? extprop_sortorder_value { get; set; }
        [Column(Name = "extprop_is_expanded")]
        [DataMember]
        public Int64? extprop_is_expanded { get; set; }
    }

    [Table(Name = "Videos")]
    [DataContract]
    public class VideosRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "error")]
        [DataMember]
        public string error { get; set; }
        [Column(Name = "debuginfo")]
        [DataMember]
        public string debuginfo { get; set; }
        [Column(Name = "dimensions")]
        [DataMember]
        public string dimensions { get; set; }
        [Column(Name = "media_type")]
        [DataMember]
        public Int64? media_type { get; set; }
        [Column(Name = "duration_1080")]
        [DataMember]
        public Int64? duration_1080 { get; set; }
        [Column(Name = "duration_720")]
        [DataMember]
        public Int64? duration_720 { get; set; }
        [Column(Name = "duration_hqv")]
        [DataMember]
        public Int64? duration_hqv { get; set; }
        [Column(Name = "duration_vgad2")]
        [DataMember]
        public Int64? duration_vgad2 { get; set; }
        [Column(Name = "duration_ltvgad2")]
        [DataMember]
        public Int64? duration_ltvgad2 { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "hq_present")]
        [DataMember]
        public Int64? hq_present { get; set; }
        [Column(Name = "duration_ss")]
        [DataMember]
        public Int64? duration_ss { get; set; }
        [Column(Name = "ss_timestamp")]
        [DataMember]
        public Int64? ss_timestamp { get; set; }
        [Column(Name = "convo_id")]
        [DataMember]
        public Int64? convo_id { get; set; }
        [Column(Name = "device_path")]
        [DataMember]
        public string device_path { get; set; }
        [Column(Name = "device_name")]
        [DataMember]
        public string device_name { get; set; }
        [Column(Name = "participant_id")]
        [DataMember]
        public Int64? participant_id { get; set; }
    }

    [Table(Name = "SMSes")]
    [DataContract]
    public class SMSesRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "outgoing_reply_type")]
        [DataMember]
        public Int64? outgoing_reply_type { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "failurereason")]
        [DataMember]
        public Int64? failurereason { get; set; }
        [Column(Name = "error_category")]
        [DataMember]
        public Int64? error_category { get; set; }
        [Column(Name = "is_failed_unseen")]
        [DataMember]
        public Int64? is_failed_unseen { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "price")]
        [DataMember]
        public Int64? price { get; set; }
        [Column(Name = "price_precision")]
        [DataMember]
        public Int64? price_precision { get; set; }
        [Column(Name = "price_currency")]
        [DataMember]
        public string price_currency { get; set; }
        [Column(Name = "reply_to_number")]
        [DataMember]
        public string reply_to_number { get; set; }
        [Column(Name = "target_numbers")]
        [DataMember]
        public string target_numbers { get; set; }
        [Column(Name = "target_statuses")]
        [DataMember]
        public byte[] target_statuses { get; set; }
        [Column(Name = "body")]
        [DataMember]
        public string body { get; set; }
        [Column(Name = "chatmsg_id")]
        [DataMember]
        public Int64? chatmsg_id { get; set; }
        [Column(Name = "identity")]
        [DataMember]
        public string identity { get; set; }
        [Column(Name = "notification_id")]
        [DataMember]
        public Int64? notification_id { get; set; }
        [Column(Name = "event_flags")]
        [DataMember]
        public Int64? event_flags { get; set; }
        [Column(Name = "reply_id_number")]
        [DataMember]
        public string reply_id_number { get; set; }
        [Column(Name = "convo_name")]
        [DataMember]
        public string convo_name { get; set; }
        [Column(Name = "extprop_hide_from_history")]
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
        [Column(Name = "extprop_extended")]
        [DataMember]
        public Int64? extprop_extended { get; set; }
    }

    [Table(Name = "CallMembers")]
    [DataContract]
    public class CallMembersRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "identity")]
        [DataMember]
        public string identity { get; set; }
        [Column(Name = "dispname")]
        [DataMember]
        public string dispname { get; set; }
        [Column(Name = "languages")]
        [DataMember]
        public string languages { get; set; }
        [Column(Name = "call_duration")]
        [DataMember]
        public Int64? call_duration { get; set; }
        [Column(Name = "price_per_minute")]
        [DataMember]
        public Int64? price_per_minute { get; set; }
        [Column(Name = "price_precision")]
        [DataMember]
        public Int64? price_precision { get; set; }
        [Column(Name = "price_currency")]
        [DataMember]
        public string price_currency { get; set; }
        [Column(Name = "payment_category")]
        [DataMember]
        public string payment_category { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "failurereason")]
        [DataMember]
        public Int64? failurereason { get; set; }
        [Column(Name = "sounderror_code")]
        [DataMember]
        public Int64? sounderror_code { get; set; }
        [Column(Name = "soundlevel")]
        [DataMember]
        public Int64? soundlevel { get; set; }
        [Column(Name = "pstn_statustext")]
        [DataMember]
        public string pstn_statustext { get; set; }
        [Column(Name = "pstn_feedback")]
        [DataMember]
        public string pstn_feedback { get; set; }
        [Column(Name = "forward_targets")]
        [DataMember]
        public string forward_targets { get; set; }
        [Column(Name = "forwarded_by")]
        [DataMember]
        public string forwarded_by { get; set; }
        [Column(Name = "debuginfo")]
        [DataMember]
        public string debuginfo { get; set; }
        [Column(Name = "videostatus")]
        [DataMember]
        public Int64? videostatus { get; set; }
        [Column(Name = "target_identity")]
        [DataMember]
        public string target_identity { get; set; }
        [Column(Name = "mike_status")]
        [DataMember]
        public Int64? mike_status { get; set; }
        [Column(Name = "is_read_only")]
        [DataMember]
        public Int64? is_read_only { get; set; }
        [Column(Name = "quality_status")]
        [DataMember]
        public Int64? quality_status { get; set; }
        [Column(Name = "call_name")]
        [DataMember]
        public string call_name { get; set; }
        [Column(Name = "transfer_status")]
        [DataMember]
        public Int64? transfer_status { get; set; }
        [Column(Name = "transfer_active")]
        [DataMember]
        public Int64? transfer_active { get; set; }
        [Column(Name = "transferred_by")]
        [DataMember]
        public string transferred_by { get; set; }
        [Column(Name = "transferred_to")]
        [DataMember]
        public string transferred_to { get; set; }
        [Column(Name = "guid")]
        [DataMember]
        public string guid { get; set; }
        [Column(Name = "next_redial_time")]
        [DataMember]
        public Int64? next_redial_time { get; set; }
        [Column(Name = "nrof_redials_done")]
        [DataMember]
        public Int64? nrof_redials_done { get; set; }
        [Column(Name = "nrof_redials_left")]
        [DataMember]
        public Int64? nrof_redials_left { get; set; }
        [Column(Name = "transfer_topic")]
        [DataMember]
        public string transfer_topic { get; set; }
        [Column(Name = "real_identity")]
        [DataMember]
        public string real_identity { get; set; }
        [Column(Name = "start_timestamp")]
        [DataMember]
        public Int64? start_timestamp { get; set; }
        [Column(Name = "is_conference")]
        [DataMember]
        public Int64? is_conference { get; set; }
        [Column(Name = "quality_problems")]
        [DataMember]
        public string quality_problems { get; set; }
        [Column(Name = "identity_type")]
        [DataMember]
        public Int64? identity_type { get; set; }
        [Column(Name = "country")]
        [DataMember]
        public string country { get; set; }
        [Column(Name = "creation_timestamp")]
        [DataMember]
        public Int64? creation_timestamp { get; set; }
        [Column(Name = "stats_xml")]
        [DataMember]
        public string stats_xml { get; set; }
        [Column(Name = "is_premium_video_sponsor")]
        [DataMember]
        public Int64? is_premium_video_sponsor { get; set; }
        [Column(Name = "is_multiparty_video_capable")]
        [DataMember]
        public Int64? is_multiparty_video_capable { get; set; }
        [Column(Name = "recovery_in_progress")]
        [DataMember]
        public Int64? recovery_in_progress { get; set; }
        [Column(Name = "fallback_in_progress")]
        [DataMember]
        public Int64? fallback_in_progress { get; set; }
        [Column(Name = "nonse_word")]
        [DataMember]
        public string nonse_word { get; set; }
        [Column(Name = "nr_of_delivered_push_notifications")]
        [DataMember]
        public Int64? nr_of_delivered_push_notifications { get; set; }
        [Column(Name = "call_session_guid")]
        [DataMember]
        public string call_session_guid { get; set; }
        [Column(Name = "version_string")]
        [DataMember]
        public string version_string { get; set; }
        [Column(Name = "ip_address")]
        [DataMember]
        public string ip_address { get; set; }
        [Column(Name = "is_video_codec_compatible")]
        [DataMember]
        public Int64? is_video_codec_compatible { get; set; }
        [Column(Name = "group_calling_capabilities")]
        [DataMember]
        public Int64? group_calling_capabilities { get; set; }
        [Column(Name = "mri_identity")]
        [DataMember]
        public string mri_identity { get; set; }
        [Column(Name = "is_seamlessly_upgraded_call")]
        [DataMember]
        public Int64? is_seamlessly_upgraded_call { get; set; }
        [Column(Name = "voicechannel")]
        [DataMember]
        public Int64? voicechannel { get; set; }
        [Column(Name = "video_count_changed")]
        [DataMember]
        public Int64? video_count_changed { get; set; }
        [Column(Name = "is_active_speaker")]
        [DataMember]
        public Int64? is_active_speaker { get; set; }
        [Column(Name = "dominant_speaker_rank")]
        [DataMember]
        public Int64? dominant_speaker_rank { get; set; }
        [Column(Name = "participant_sponsor")]
        [DataMember]
        public string participant_sponsor { get; set; }
        [Column(Name = "content_sharing_role")]
        [DataMember]
        public Int64? content_sharing_role { get; set; }
        [Column(Name = "endpoint_details")]
        [DataMember]
        public string endpoint_details { get; set; }
        [Column(Name = "pk_status")]
        [DataMember]
        public Int64? pk_status { get; set; }
        [Column(Name = "call_db_id")]
        [DataMember]
        public Int64? call_db_id { get; set; }
        [Column(Name = "prime_status")]
        [DataMember]
        public Int64? prime_status { get; set; }
    }

    [Table(Name = "ChatMembers")]
    [DataContract]
    public class ChatMembersRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "chatname")]
        [DataMember]
        public string chatname { get; set; }
        [Column(Name = "identity")]
        [DataMember]
        public string identity { get; set; }
        [Column(Name = "role")]
        [DataMember]
        public Int64? role { get; set; }
        [Column(Name = "is_active")]
        [DataMember]
        public Int64? is_active { get; set; }
        [Column(Name = "cur_activities")]
        [DataMember]
        public Int64? cur_activities { get; set; }
        [Column(Name = "adder")]
        [DataMember]
        public string adder { get; set; }
    }

    [Table(Name = "Alerts")]
    [DataContract]
    public class AlertsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "partner_name")]
        [DataMember]
        public string partner_name { get; set; }
        [Column(Name = "is_unseen")]
        [DataMember]
        public Int64? is_unseen { get; set; }
        [Column(Name = "partner_id")]
        [DataMember]
        public Int64? partner_id { get; set; }
        [Column(Name = "partner_event")]
        [DataMember]
        public string partner_event { get; set; }
        [Column(Name = "partner_history")]
        [DataMember]
        public string partner_history { get; set; }
        [Column(Name = "partner_header")]
        [DataMember]
        public string partner_header { get; set; }
        [Column(Name = "partner_logo")]
        [DataMember]
        public string partner_logo { get; set; }
        [Column(Name = "meta_expiry")]
        [DataMember]
        public Int64? meta_expiry { get; set; }
        [Column(Name = "message_header_caption")]
        [DataMember]
        public string message_header_caption { get; set; }
        [Column(Name = "message_header_title")]
        [DataMember]
        public string message_header_title { get; set; }
        [Column(Name = "message_header_subject")]
        [DataMember]
        public string message_header_subject { get; set; }
        [Column(Name = "message_header_cancel")]
        [DataMember]
        public string message_header_cancel { get; set; }
        [Column(Name = "message_header_later")]
        [DataMember]
        public string message_header_later { get; set; }
        [Column(Name = "message_content")]
        [DataMember]
        public string message_content { get; set; }
        [Column(Name = "message_footer")]
        [DataMember]
        public string message_footer { get; set; }
        [Column(Name = "message_button_caption")]
        [DataMember]
        public string message_button_caption { get; set; }
        [Column(Name = "message_button_uri")]
        [DataMember]
        public string message_button_uri { get; set; }
        [Column(Name = "message_type")]
        [DataMember]
        public Int64? message_type { get; set; }
        [Column(Name = "window_size")]
        [DataMember]
        public Int64? window_size { get; set; }
        [Column(Name = "chatmsg_guid")]
        [DataMember]
        public byte[] chatmsg_guid { get; set; }
        [Column(Name = "notification_id")]
        [DataMember]
        public Int64? notification_id { get; set; }
        [Column(Name = "event_flags")]
        [DataMember]
        public Int64? event_flags { get; set; }
        [Column(Name = "extprop_hide_from_history")]
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
    }

    [Table(Name = "Conversations")]
    [DataContract]
    public class ConversationsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "identity")]
        [DataMember]
        public string identity { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "live_host")]
        [DataMember]
        public string live_host { get; set; }
        [Column(Name = "live_is_hostless")]
        [DataMember]
        public Int64? live_is_hostless { get; set; }
        [Column(Name = "live_call_technology")]
        [DataMember]
        public Int64? live_call_technology { get; set; }
        [Column(Name = "optimal_remote_videos_in_conference")]
        [DataMember]
        public Int64? optimal_remote_videos_in_conference { get; set; }
        [Column(Name = "live_start_timestamp")]
        [DataMember]
        public Int64? live_start_timestamp { get; set; }
        [Column(Name = "live_is_muted")]
        [DataMember]
        public Int64? live_is_muted { get; set; }
        [Column(Name = "max_videoconfcall_participants")]
        [DataMember]
        public Int64? max_videoconfcall_participants { get; set; }
        [Column(Name = "alert_string")]
        [DataMember]
        public string alert_string { get; set; }
        [Column(Name = "is_bookmarked")]
        [DataMember]
        public Int64? is_bookmarked { get; set; }
        [Column(Name = "is_blocked")]
        [DataMember]
        public Int64? is_blocked { get; set; }
        [Column(Name = "given_displayname")]
        [DataMember]
        public string given_displayname { get; set; }
        [Column(Name = "displayname")]
        [DataMember]
        public string displayname { get; set; }
        [Column(Name = "local_livestatus")]
        [DataMember]
        public Int64? local_livestatus { get; set; }
        [Column(Name = "inbox_timestamp")]
        [DataMember]
        public Int64? inbox_timestamp { get; set; }
        [Column(Name = "inbox_message_id")]
        [DataMember]
        public Int64? inbox_message_id { get; set; }
        [Column(Name = "last_message_id")]
        [DataMember]
        public Int64? last_message_id { get; set; }
        [Column(Name = "unconsumed_suppressed_messages")]
        [DataMember]
        public Int64? unconsumed_suppressed_messages { get; set; }
        [Column(Name = "unconsumed_normal_messages")]
        [DataMember]
        public Int64? unconsumed_normal_messages { get; set; }
        [Column(Name = "unconsumed_elevated_messages")]
        [DataMember]
        public Int64? unconsumed_elevated_messages { get; set; }
        [Column(Name = "unconsumed_messages_voice")]
        [DataMember]
        public Int64? unconsumed_messages_voice { get; set; }
        [Column(Name = "active_vm_id")]
        [DataMember]
        public Int64? active_vm_id { get; set; }
        [Column(Name = "context_horizon")]
        [DataMember]
        public Int64? context_horizon { get; set; }
        [Column(Name = "consumption_horizon")]
        [DataMember]
        public Int64? consumption_horizon { get; set; }
        [Column(Name = "consumption_horizon__ms")]
        [DataMember]
        public Int64? consumption_horizon__ms { get; set; }
        [Column(Name = "last_activity_timestamp")]
        [DataMember]
        public Int64? last_activity_timestamp { get; set; }
        [Column(Name = "active_invoice_message")]
        [DataMember]
        public Int64? active_invoice_message { get; set; }
        [Column(Name = "spawned_from_convo_id")]
        [DataMember]
        public Int64? spawned_from_convo_id { get; set; }
        [Column(Name = "pinned_order")]
        [DataMember]
        public Int64? pinned_order { get; set; }
        [Column(Name = "creator")]
        [DataMember]
        public string creator { get; set; }
        [Column(Name = "creation_timestamp")]
        [DataMember]
        public Int64? creation_timestamp { get; set; }
        [Column(Name = "my_status")]
        [DataMember]
        public Int64? my_status { get; set; }
        [Column(Name = "opt_joining_enabled")]
        [DataMember]
        public Int64? opt_joining_enabled { get; set; }
        [Column(Name = "opt_moderated")]
        [DataMember]
        public Int64? opt_moderated { get; set; }
        [Column(Name = "opt_access_token")]
        [DataMember]
        public string opt_access_token { get; set; }
        [Column(Name = "opt_entry_level_rank")]
        [DataMember]
        public Int64? opt_entry_level_rank { get; set; }
        [Column(Name = "opt_disclose_history")]
        [DataMember]
        public Int64? opt_disclose_history { get; set; }
        [Column(Name = "opt_history_limit_in_days")]
        [DataMember]
        public Int64? opt_history_limit_in_days { get; set; }
        [Column(Name = "opt_admin_only_activities")]
        [DataMember]
        public Int64? opt_admin_only_activities { get; set; }
        [Column(Name = "passwordhint")]
        [DataMember]
        public string passwordhint { get; set; }
        [Column(Name = "meta_name")]
        [DataMember]
        public string meta_name { get; set; }
        [Column(Name = "meta_topic")]
        [DataMember]
        public string meta_topic { get; set; }
        [Column(Name = "meta_guidelines")]
        [DataMember]
        public string meta_guidelines { get; set; }
        [Column(Name = "meta_picture")]
        [DataMember]
        public byte[] meta_picture { get; set; }
        [Column(Name = "picture")]
        [DataMember]
        public string picture { get; set; }
        [Column(Name = "is_p2p_migrated")]
        [DataMember]
        public Int64? is_p2p_migrated { get; set; }
        [Column(Name = "migration_instructions_posted")]
        [DataMember]
        public Int64? migration_instructions_posted { get; set; }
        [Column(Name = "premium_video_status")]
        [DataMember]
        public Int64? premium_video_status { get; set; }
        [Column(Name = "premium_video_is_grace_period")]
        [DataMember]
        public Int64? premium_video_is_grace_period { get; set; }
        [Column(Name = "guid")]
        [DataMember]
        public string guid { get; set; }
        [Column(Name = "dialog_partner")]
        [DataMember]
        public string dialog_partner { get; set; }
        [Column(Name = "meta_description")]
        [DataMember]
        public string meta_description { get; set; }
        [Column(Name = "premium_video_sponsor_list")]
        [DataMember]
        public string premium_video_sponsor_list { get; set; }
        [Column(Name = "mcr_caller")]
        [DataMember]
        public string mcr_caller { get; set; }
        [Column(Name = "chat_dbid")]
        [DataMember]
        public Int64? chat_dbid { get; set; }
        [Column(Name = "history_horizon")]
        [DataMember]
        public Int64? history_horizon { get; set; }
        [Column(Name = "history_sync_state")]
        [DataMember]
        public string history_sync_state { get; set; }
        [Column(Name = "thread_version")]
        [DataMember]
        public string thread_version { get; set; }
        [Column(Name = "consumption_horizon_set_at")]
        [DataMember]
        public Int64? consumption_horizon_set_at { get; set; }
        [Column(Name = "alt_identity")]
        [DataMember]
        public string alt_identity { get; set; }
        [Column(Name = "in_migrated_thread_since")]
        [DataMember]
        public Int64? in_migrated_thread_since { get; set; }
        [Column(Name = "awareness_liveState")]
        [DataMember]
        public string awareness_liveState { get; set; }
        [Column(Name = "join_url")]
        [DataMember]
        public string join_url { get; set; }
        [Column(Name = "reaction_thread")]
        [DataMember]
        public string reaction_thread { get; set; }
        [Column(Name = "parent_thread")]
        [DataMember]
        public string parent_thread { get; set; }
        [Column(Name = "consumption_horizon_rid")]
        [DataMember]
        public Int64? consumption_horizon_rid { get; set; }
        [Column(Name = "consumption_horizon_crc")]
        [DataMember]
        public Int64? consumption_horizon_crc { get; set; }
        [Column(Name = "consumption_horizon_bookmark")]
        [DataMember]
        public Int64? consumption_horizon_bookmark { get; set; }
        [Column(Name = "client_id")]
        [DataMember]
        public string client_id { get; set; }
        [Column(Name = "last_synced_message_id")]
        [DataMember]
        public Int64? last_synced_message_id { get; set; }
        [Column(Name = "last_synced_message_version")]
        [DataMember]
        public Int64? last_synced_message_version { get; set; }
        [Column(Name = "last_synced_days")]
        [DataMember]
        public Int64? last_synced_days { get; set; }
        [Column(Name = "version")]
        [DataMember]
        public Int64? version { get; set; }
        [Column(Name = "endpoint_details")]
        [DataMember]
        public string endpoint_details { get; set; }
        [Column(Name = "extprop_profile_height")]
        [DataMember]
        public Int64? extprop_profile_height { get; set; }
        [Column(Name = "extprop_chat_width")]
        [DataMember]
        public Int64? extprop_chat_width { get; set; }
        [Column(Name = "extprop_chat_left_margin")]
        [DataMember]
        public Int64? extprop_chat_left_margin { get; set; }
        [Column(Name = "extprop_chat_right_margin")]
        [DataMember]
        public Int64? extprop_chat_right_margin { get; set; }
        [Column(Name = "extprop_entry_height")]
        [DataMember]
        public Int64? extprop_entry_height { get; set; }
        [Column(Name = "extprop_windowpos_x")]
        [DataMember]
        public Int64? extprop_windowpos_x { get; set; }
        [Column(Name = "extprop_windowpos_y")]
        [DataMember]
        public Int64? extprop_windowpos_y { get; set; }
        [Column(Name = "extprop_windowpos_w")]
        [DataMember]
        public Int64? extprop_windowpos_w { get; set; }
        [Column(Name = "extprop_windowpos_h")]
        [DataMember]
        public Int64? extprop_windowpos_h { get; set; }
        [Column(Name = "extprop_window_maximized")]
        [DataMember]
        public Int64? extprop_window_maximized { get; set; }
        [Column(Name = "extprop_window_detached")]
        [DataMember]
        public Int64? extprop_window_detached { get; set; }
        [Column(Name = "extprop_pinned_order")]
        [DataMember]
        public Int64? extprop_pinned_order { get; set; }
        [Column(Name = "extprop_new_in_inbox")]
        [DataMember]
        public Int64? extprop_new_in_inbox { get; set; }
        [Column(Name = "extprop_tab_order")]
        [DataMember]
        public Int64? extprop_tab_order { get; set; }
        [Column(Name = "extprop_video_layout")]
        [DataMember]
        public Int64? extprop_video_layout { get; set; }
        [Column(Name = "extprop_video_chat_height")]
        [DataMember]
        public Int64? extprop_video_chat_height { get; set; }
        [Column(Name = "extprop_chat_avatar")]
        [DataMember]
        public Int64? extprop_chat_avatar { get; set; }
        [Column(Name = "extprop_consumption_timestamp")]
        [DataMember]
        public Int64? extprop_consumption_timestamp { get; set; }
        [Column(Name = "extprop_form_visible")]
        [DataMember]
        public Int64? extprop_form_visible { get; set; }
        [Column(Name = "extprop_recovery_mode")]
        [DataMember]
        public Int64? extprop_recovery_mode { get; set; }
        [Column(Name = "extprop_translator_enabled")]
        [DataMember]
        public Int64? extprop_translator_enabled { get; set; }
        [Column(Name = "extprop_translator_call_my_lang")]
        [DataMember]
        public string extprop_translator_call_my_lang { get; set; }
        [Column(Name = "extprop_translator_call_other_lang")]
        [DataMember]
        public string extprop_translator_call_other_lang { get; set; }
        [Column(Name = "extprop_translator_chat_my_lang")]
        [DataMember]
        public string extprop_translator_chat_my_lang { get; set; }
        [Column(Name = "extprop_translator_chat_other_lang")]
        [DataMember]
        public string extprop_translator_chat_other_lang { get; set; }
        [Column(Name = "extprop_conversation_first_unread_emote")]
        [DataMember]
        public Int64? extprop_conversation_first_unread_emote { get; set; }
        [Column(Name = "datachannel_object_id")]
        [DataMember]
        public Int64? datachannel_object_id { get; set; }
        [Column(Name = "invite_status")]
        [DataMember]
        public Int64? invite_status { get; set; }
        [Column(Name = "highlights_follow_pending")]
        [DataMember]
        public string highlights_follow_pending { get; set; }
        [Column(Name = "highlights_follow_waiting")]
        [DataMember]
        public string highlights_follow_waiting { get; set; }
        [Column(Name = "highlights_add_pending")]
        [DataMember]
        public string highlights_add_pending { get; set; }
        [Column(Name = "highlights_add_waiting")]
        [DataMember]
        public string highlights_add_waiting { get; set; }
    }

    [Table(Name = "Participants")]
    [DataContract]
    public class ParticipantsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "convo_id")]
        [DataMember]
        public Int64? convo_id { get; set; }
        [Column(Name = "identity")]
        [DataMember]
        public string identity { get; set; }
        [Column(Name = "rank")]
        [DataMember]
        public Int64? rank { get; set; }
        [Column(Name = "requested_rank")]
        [DataMember]
        public Int64? requested_rank { get; set; }
        [Column(Name = "text_status")]
        [DataMember]
        public Int64? text_status { get; set; }
        [Column(Name = "voice_status")]
        [DataMember]
        public Int64? voice_status { get; set; }
        [Column(Name = "live_identity")]
        [DataMember]
        public string live_identity { get; set; }
        [Column(Name = "live_price_for_me")]
        [DataMember]
        public string live_price_for_me { get; set; }
        [Column(Name = "live_fwd_identities")]
        [DataMember]
        public string live_fwd_identities { get; set; }
        [Column(Name = "live_start_timestamp")]
        [DataMember]
        public Int64? live_start_timestamp { get; set; }
        [Column(Name = "sound_level")]
        [DataMember]
        public Int64? sound_level { get; set; }
        [Column(Name = "debuginfo")]
        [DataMember]
        public string debuginfo { get; set; }
        [Column(Name = "next_redial_time")]
        [DataMember]
        public Int64? next_redial_time { get; set; }
        [Column(Name = "nrof_redials_left")]
        [DataMember]
        public Int64? nrof_redials_left { get; set; }
        [Column(Name = "last_voice_error")]
        [DataMember]
        public string last_voice_error { get; set; }
        [Column(Name = "quality_problems")]
        [DataMember]
        public string quality_problems { get; set; }
        [Column(Name = "live_type")]
        [DataMember]
        public Int64? live_type { get; set; }
        [Column(Name = "live_country")]
        [DataMember]
        public string live_country { get; set; }
        [Column(Name = "transferred_by")]
        [DataMember]
        public string transferred_by { get; set; }
        [Column(Name = "transferred_to")]
        [DataMember]
        public string transferred_to { get; set; }
        [Column(Name = "adder")]
        [DataMember]
        public string adder { get; set; }
        [Column(Name = "sponsor")]
        [DataMember]
        public string sponsor { get; set; }
        [Column(Name = "last_leavereason")]
        [DataMember]
        public Int64? last_leavereason { get; set; }
        [Column(Name = "is_premium_video_sponsor")]
        [DataMember]
        public Int64? is_premium_video_sponsor { get; set; }
        [Column(Name = "is_multiparty_video_capable")]
        [DataMember]
        public Int64? is_multiparty_video_capable { get; set; }
        [Column(Name = "live_identity_to_use")]
        [DataMember]
        public string live_identity_to_use { get; set; }
        [Column(Name = "livesession_recovery_in_progress")]
        [DataMember]
        public Int64? livesession_recovery_in_progress { get; set; }
        [Column(Name = "livesession_fallback_in_progress")]
        [DataMember]
        public Int64? livesession_fallback_in_progress { get; set; }
        [Column(Name = "is_multiparty_video_updatable")]
        [DataMember]
        public Int64? is_multiparty_video_updatable { get; set; }
        [Column(Name = "live_ip_address")]
        [DataMember]
        public string live_ip_address { get; set; }
        [Column(Name = "is_video_codec_compatible")]
        [DataMember]
        public Int64? is_video_codec_compatible { get; set; }
        [Column(Name = "group_calling_capabilities")]
        [DataMember]
        public Int64? group_calling_capabilities { get; set; }
        [Column(Name = "is_seamlessly_upgraded_call")]
        [DataMember]
        public Int64? is_seamlessly_upgraded_call { get; set; }
        [Column(Name = "live_voicechannel")]
        [DataMember]
        public Int64? live_voicechannel { get; set; }
        [Column(Name = "read_horizon")]
        [DataMember]
        public Int64? read_horizon { get; set; }
        [Column(Name = "is_active_speaker")]
        [DataMember]
        public Int64? is_active_speaker { get; set; }
        [Column(Name = "dominant_speaker_rank")]
        [DataMember]
        public Int64? dominant_speaker_rank { get; set; }
        [Column(Name = "endpoint_details")]
        [DataMember]
        public string endpoint_details { get; set; }
        [Column(Name = "messaging_mode")]
        [DataMember]
        public Int64? messaging_mode { get; set; }
        [Column(Name = "real_identity")]
        [DataMember]
        public string real_identity { get; set; }
        [Column(Name = "adding_in_progress_since")]
        [DataMember]
        public Int64? adding_in_progress_since { get; set; }
    }

    [Table(Name = "VideoMessages")]
    [DataContract]
    public class VideoMessagesRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "qik_id")]
        [DataMember]
        public byte[] qik_id { get; set; }
        [Column(Name = "attached_msg_ids")]
        [DataMember]
        public string attached_msg_ids { get; set; }
        [Column(Name = "sharing_id")]
        [DataMember]
        public string sharing_id { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "vod_status")]
        [DataMember]
        public Int64? vod_status { get; set; }
        [Column(Name = "vod_path")]
        [DataMember]
        public string vod_path { get; set; }
        [Column(Name = "local_path")]
        [DataMember]
        public string local_path { get; set; }
        [Column(Name = "public_link")]
        [DataMember]
        public string public_link { get; set; }
        [Column(Name = "progress")]
        [DataMember]
        public Int64? progress { get; set; }
        [Column(Name = "title")]
        [DataMember]
        public string title { get; set; }
        [Column(Name = "description")]
        [DataMember]
        public string description { get; set; }
        [Column(Name = "author")]
        [DataMember]
        public string author { get; set; }
        [Column(Name = "creation_timestamp")]
        [DataMember]
        public Int64? creation_timestamp { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public string type { get; set; }
    }

    [Table(Name = "MediaDocuments")]
    [DataContract]
    public class MediaDocumentsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "storage_document_id")]
        [DataMember]
        public Int64? storage_document_id { get; set; }
        [Column(Name = "sending_status")]
        [DataMember]
        public Int64? sending_status { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "doc_type")]
        [DataMember]
        public Int64? doc_type { get; set; }
        [Column(Name = "uri")]
        [DataMember]
        public string uri { get; set; }
        [Column(Name = "original_name")]
        [DataMember]
        public string original_name { get; set; }
        [Column(Name = "title")]
        [DataMember]
        public string title { get; set; }
        [Column(Name = "description")]
        [DataMember]
        public string description { get; set; }
        [Column(Name = "thumbnail_url")]
        [DataMember]
        public string thumbnail_url { get; set; }
        [Column(Name = "web_url")]
        [DataMember]
        public string web_url { get; set; }
        [Column(Name = "mime_type")]
        [DataMember]
        public string mime_type { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public string type { get; set; }
        [Column(Name = "service")]
        [DataMember]
        public string service { get; set; }
        [Column(Name = "consumption_status")]
        [DataMember]
        public Int64? consumption_status { get; set; }
        [Column(Name = "convo_id")]
        [DataMember]
        public Int64? convo_id { get; set; }
        [Column(Name = "message_id")]
        [DataMember]
        public Int64? message_id { get; set; }
        [Column(Name = "ams_id")]
        [DataMember]
        public string ams_id { get; set; }
    }

    [Table(Name = "Translators")]
    [DataContract]
    public class TranslatorsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
    }

    [Table(Name = "MessageAnnotations")]
    [DataContract]
    public class MessageAnnotationsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "message_id")]
        [DataMember]
        public Int64? message_id { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "key")]
        [DataMember]
        public string key { get; set; }
        [Column(Name = "value")]
        [DataMember]
        public string @value { get; set; }
        [Column(Name = "author")]
        [DataMember]
        public string author { get; set; }
        [Column(Name = "timestamp")]
        [DataMember]
        public Int64? timestamp { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
    }

    [Table(Name = "CallHandlers")]
    [DataContract]
    public class CallHandlersRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
    }

    [Table(Name = "ConversationViews")]
    [DataContract]
    public class ConversationViewsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "view_id")]
        [DataMember]
        public Int64? view_id { get; set; }
    }

    [Table(Name = "ContentSharings")]
    [DataContract]
    public class ContentSharingsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "call_id")]
        [DataMember]
        public Int64? call_id { get; set; }
        [Column(Name = "identity")]
        [DataMember]
        public string identity { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
        [Column(Name = "sharing_id")]
        [DataMember]
        public string sharing_id { get; set; }
        [Column(Name = "state")]
        [DataMember]
        public string state { get; set; }
        [Column(Name = "failurereason")]
        [DataMember]
        public Int64? failurereason { get; set; }
        [Column(Name = "failurecode")]
        [DataMember]
        public Int64? failurecode { get; set; }
        [Column(Name = "failuresubcode")]
        [DataMember]
        public Int64? failuresubcode { get; set; }
    }

    [Table(Name = "DataChannels")]
    [DataContract]
    public class DataChannelsRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "is_permanent")]
        [DataMember]
        public Int64? is_permanent { get; set; }
        [Column(Name = "status")]
        [DataMember]
        public Int64? status { get; set; }
    }

    [Table(Name = "tracker_journal")]
    [DataContract]
    public class tracker_journalRecord
    {
        [Column(Name = "id", IsPrimaryKey = true)]
        [DataMember, Required]
        public Int64 id { get; set; }
        [Column(Name = "dbID")]
        [DataMember]
        public Int64? dbID { get; set; }
        [Column(Name = "type")]
        [DataMember]
        public Int64? type { get; set; }
        [Column(Name = "change")]
        [DataMember]
        public Int64? change { get; set; }
    }

    [DataContract]
    public class SkypeMainDbDataSet
    {
        [DataMember]
        public List<DbMetaRecord> DbMeta { get; set; }
        [DataMember]
        public List<AppSchemaVersionRecord> AppSchemaVersion { get; set; }
        [DataMember]
        public List<ContactsRecord> Contacts { get; set; }
        [DataMember]
        public List<LegacyMessagesRecord> LegacyMessages { get; set; }
        [DataMember]
        public List<CallsRecord> Calls { get; set; }
        [DataMember]
        public List<AccountsRecord> Accounts { get; set; }
        [DataMember]
        public List<TransfersRecord> Transfers { get; set; }
        [DataMember]
        public List<VoicemailsRecord> Voicemails { get; set; }
        [DataMember]
        public List<ChatsRecord> Chats { get; set; }
        [DataMember]
        public List<MessagesRecord> Messages { get; set; }
        [DataMember]
        public List<ContactGroupsRecord> ContactGroups { get; set; }
        [DataMember]
        public List<VideosRecord> Videos { get; set; }
        [DataMember]
        public List<SMSesRecord> SMSes { get; set; }
        [DataMember]
        public List<CallMembersRecord> CallMembers { get; set; }
        [DataMember]
        public List<ChatMembersRecord> ChatMembers { get; set; }
        [DataMember]
        public List<AlertsRecord> Alerts { get; set; }
        [DataMember]
        public List<ConversationsRecord> Conversations { get; set; }
        [DataMember]
        public List<ParticipantsRecord> Participants { get; set; }
        [DataMember]
        public List<VideoMessagesRecord> VideoMessages { get; set; }
        [DataMember]
        public List<MediaDocumentsRecord> MediaDocuments { get; set; }
        [DataMember]
        public List<TranslatorsRecord> Translators { get; set; }
        [DataMember]
        public List<MessageAnnotationsRecord> MessageAnnotations { get; set; }
        [DataMember]
        public List<CallHandlersRecord> CallHandlers { get; set; }
        [DataMember]
        public List<ConversationViewsRecord> ConversationViews { get; set; }
        [DataMember]
        public List<ContentSharingsRecord> ContentSharings { get; set; }
        [DataMember]
        public List<DataChannelsRecord> DataChannels { get; set; }
        [DataMember]
        public List<tracker_journalRecord> tracker_journal { get; set; }

        public static SkypeMainDbDataSet LoadDataFromFile(string dataBaseFilePath)
        {
            var ret = new SkypeMainDbDataSet();
            using (var conn = new System.Data.SQLite.SQLiteConnection("Data Source=" + dataBaseFilePath))
            {
                conn.Open();
                using (var reader = new System.Data.Linq.DataContext(conn))
                {
                    ret.DbMeta = reader.GetTable<DbMetaRecord>().ToList();
                    ret.AppSchemaVersion = reader.GetTable<AppSchemaVersionRecord>().ToList();
                    ret.Contacts = reader.GetTable<ContactsRecord>().ToList();
                    ret.LegacyMessages = reader.GetTable<LegacyMessagesRecord>().ToList();
                    ret.Calls = reader.GetTable<CallsRecord>().ToList();
                    ret.Accounts = reader.GetTable<AccountsRecord>().ToList();
                    ret.Transfers = reader.GetTable<TransfersRecord>().ToList();
                    ret.Voicemails = reader.GetTable<VoicemailsRecord>().ToList();
                    ret.Chats = reader.GetTable<ChatsRecord>().ToList();
                    ret.Messages = reader.GetTable<MessagesRecord>().ToList();
                    ret.ContactGroups = reader.GetTable<ContactGroupsRecord>().ToList();
                    ret.Videos = reader.GetTable<VideosRecord>().ToList();
                    ret.SMSes = reader.GetTable<SMSesRecord>().ToList();
                    ret.CallMembers = reader.GetTable<CallMembersRecord>().ToList();
                    ret.ChatMembers = reader.GetTable<ChatMembersRecord>().ToList();
                    ret.Alerts = reader.GetTable<AlertsRecord>().ToList();
                    ret.Conversations = reader.GetTable<ConversationsRecord>().ToList();
                    ret.Participants = reader.GetTable<ParticipantsRecord>().ToList();
                    ret.VideoMessages = reader.GetTable<VideoMessagesRecord>().ToList();
                    ret.MediaDocuments = reader.GetTable<MediaDocumentsRecord>().ToList();
                    ret.Translators = reader.GetTable<TranslatorsRecord>().ToList();
                    ret.MessageAnnotations = reader.GetTable<MessageAnnotationsRecord>().ToList();
                    ret.CallHandlers = reader.GetTable<CallHandlersRecord>().ToList();
                    ret.ConversationViews = reader.GetTable<ConversationViewsRecord>().ToList();
                    ret.ContentSharings = reader.GetTable<ContentSharingsRecord>().ToList();
                    ret.DataChannels = reader.GetTable<DataChannelsRecord>().ToList();
                    ret.tracker_journal = reader.GetTable<tracker_journalRecord>().ToList();
                }
                conn.Close();
            }
            return ret;
        }
    }
}
