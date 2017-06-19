namespace SkypeLogExport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class DbMeta
    {
        [DataMember, Required]
        public string key { get; set; }
        [DataMember]
        public string @value { get; set; }
    }

    [DataContract]
    public class AppSchemaVersion
    {
        [DataMember, Required]
        public string ClientVersion { get; set; }
        [DataMember, Required]
        public Int64 SQLiteSchemaVersion { get; set; }
        [DataMember, Required]
        public Int64 SchemaUpdateType { get; set; }
    }

    [DataContract]
    public class Contacts
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public string skypename { get; set; }
        [DataMember]
        public string pstnnumber { get; set; }
        [DataMember]
        public string aliases { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public Int64? birthday { get; set; }
        [DataMember]
        public Int64? gender { get; set; }
        [DataMember]
        public string languages { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string province { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string phone_home { get; set; }
        [DataMember]
        public string phone_office { get; set; }
        [DataMember]
        public string phone_mobile { get; set; }
        [DataMember]
        public string emails { get; set; }
        [DataMember]
        public string hashed_emails { get; set; }
        [DataMember]
        public string homepage { get; set; }
        [DataMember]
        public string about { get; set; }
        [DataMember]
        public byte[] avatar_image { get; set; }
        [DataMember]
        public string mood_text { get; set; }
        [DataMember]
        public string rich_mood_text { get; set; }
        [DataMember]
        public Int64? timezone { get; set; }
        [DataMember]
        public byte[] capabilities { get; set; }
        [DataMember]
        public Int64? profile_timestamp { get; set; }
        [DataMember]
        public Int64? nrof_authed_buddies { get; set; }
        [DataMember]
        public string ipcountry { get; set; }
        [DataMember]
        public Int64? avatar_timestamp { get; set; }
        [DataMember]
        public Int64? mood_timestamp { get; set; }
        [DataMember]
        public string received_authrequest { get; set; }
        [DataMember]
        public Int64? authreq_timestamp { get; set; }
        [DataMember]
        public Int64? lastonline_timestamp { get; set; }
        [DataMember]
        public Int64? availability { get; set; }
        [DataMember]
        public string displayname { get; set; }
        [DataMember]
        public string firstname { get; set; }
        [DataMember]
        public string lastname { get; set; }
        [DataMember]
        public Int64? refreshing { get; set; }
        [DataMember]
        public Int64? given_authlevel { get; set; }
        [DataMember]
        public string given_displayname { get; set; }
        [DataMember]
        public string assigned_speeddial { get; set; }
        [DataMember]
        public string assigned_comment { get; set; }
        [DataMember]
        public string alertstring { get; set; }
        [DataMember]
        public Int64? lastused_timestamp { get; set; }
        [DataMember]
        public Int64? authrequest_count { get; set; }
        [DataMember]
        public string assigned_phone1 { get; set; }
        [DataMember]
        public string assigned_phone1_label { get; set; }
        [DataMember]
        public string assigned_phone2 { get; set; }
        [DataMember]
        public string assigned_phone2_label { get; set; }
        [DataMember]
        public string assigned_phone3 { get; set; }
        [DataMember]
        public string assigned_phone3_label { get; set; }
        [DataMember]
        public Int64? is_mobile { get; set; }
        [DataMember]
        public Int64? is_trusted { get; set; }
        [DataMember]
        public Int64? buddystatus { get; set; }
        [DataMember]
        public Int64? isauthorized { get; set; }
        [DataMember]
        public Int64? popularity_ord { get; set; }
        [DataMember]
        public string external_id { get; set; }
        [DataMember]
        public string external_system_id { get; set; }
        [DataMember]
        public string liveid_cid { get; set; }
        [DataMember]
        public string profile_json { get; set; }
        [DataMember]
        public string profile_etag { get; set; }
        [DataMember]
        public Int64? mutual_friend_count { get; set; }
        [DataMember]
        public Int64? isblocked { get; set; }
        [DataMember]
        public byte[] authorization_certificate { get; set; }
        [DataMember]
        public Int64? certificate_send_count { get; set; }
        [DataMember]
        public Int64? account_modification_serial_nr { get; set; }
        [DataMember]
        public byte[] saved_directory_blob { get; set; }
        [DataMember]
        public Int64? nr_of_buddies { get; set; }
        [DataMember]
        public Int64? server_synced { get; set; }
        [DataMember]
        public Int64? contactlist_track { get; set; }
        [DataMember]
        public Int64? last_used_networktime { get; set; }
        [DataMember]
        public Int64? network_availability { get; set; }
        [DataMember]
        public Int64? authorized_time { get; set; }
        [DataMember]
        public string sent_authrequest { get; set; }
        [DataMember]
        public Int64? sent_authrequest_time { get; set; }
        [DataMember]
        public Int64? sent_authrequest_serial { get; set; }
        [DataMember]
        public byte[] buddyblob { get; set; }
        [DataMember]
        public byte[] cbl_future { get; set; }
        [DataMember]
        public Int64? node_capabilities { get; set; }
        [DataMember]
        public Int64? revoked_auth { get; set; }
        [DataMember]
        public Int64? added_in_shared_group { get; set; }
        [DataMember]
        public Int64? in_shared_group { get; set; }
        [DataMember]
        public byte[] authreq_history { get; set; }
        [DataMember]
        public byte[] profile_attachments { get; set; }
        [DataMember]
        public Int64? stack_version { get; set; }
        [DataMember]
        public Int64? offline_authreq_id { get; set; }
        [DataMember]
        public Int64? node_capabilities_and { get; set; }
        [DataMember]
        public Int64? authreq_crc { get; set; }
        [DataMember]
        public Int64? authreq_src { get; set; }
        [DataMember]
        public Int64? pop_score { get; set; }
        [DataMember]
        public byte[] authreq_nodeinfo { get; set; }
        [DataMember]
        public string main_phone { get; set; }
        [DataMember]
        public string unified_servants { get; set; }
        [DataMember]
        public string phone_home_normalized { get; set; }
        [DataMember]
        public string phone_office_normalized { get; set; }
        [DataMember]
        public string phone_mobile_normalized { get; set; }
        [DataMember]
        public Int64? sent_authrequest_initmethod { get; set; }
        [DataMember]
        public Int64? authreq_initmethod { get; set; }
        [DataMember]
        public byte[] verified_email { get; set; }
        [DataMember]
        public byte[] verified_company { get; set; }
        [DataMember]
        public Int64? sent_authrequest_extrasbitmask { get; set; }
        [DataMember]
        public Int64? is_auto_buddy { get; set; }
        [DataMember]
        public Int64? group_membership { get; set; }
        [DataMember]
        public string avatar_url { get; set; }
        [DataMember]
        public string avatar_url_new { get; set; }
        [DataMember]
        public string avatar_hiresurl { get; set; }
        [DataMember]
        public string avatar_hiresurl_new { get; set; }
        [DataMember]
        public Int64? dirblob_last_search_time { get; set; }
        [DataMember]
        public Int64? extprop_seen_birthday { get; set; }
        [DataMember]
        public Int64? extprop_sms_target { get; set; }
        [DataMember]
        public string extprop_external_data { get; set; }
    }

    [DataContract]
    public class LegacyMessages
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
    }

    [DataContract]
    public class Calls
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? begin_timestamp { get; set; }
        [DataMember]
        public string topic { get; set; }
        [DataMember]
        public Int64? is_muted { get; set; }
        [DataMember]
        public Int64? is_unseen_missed { get; set; }
        [DataMember]
        public string host_identity { get; set; }
        [DataMember]
        public Int64? is_hostless { get; set; }
        [DataMember]
        public Int64? mike_status { get; set; }
        [DataMember]
        public Int64? duration { get; set; }
        [DataMember]
        public Int64? soundlevel { get; set; }
        [DataMember]
        public string access_token { get; set; }
        [DataMember]
        public Int64? active_members { get; set; }
        [DataMember]
        public Int64? is_active { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Int64? video_disabled { get; set; }
        [DataMember]
        public Int64? joined_existing { get; set; }
        [DataMember]
        public string server_identity { get; set; }
        [DataMember]
        public Int64? vaa_input_status { get; set; }
        [DataMember]
        public Int64? is_incoming { get; set; }
        [DataMember]
        public Int64? is_conference { get; set; }
        [DataMember]
        public Int64? is_on_hold { get; set; }
        [DataMember]
        public Int64? start_timestamp { get; set; }
        [DataMember]
        public string quality_problems { get; set; }
        [DataMember]
        public string current_video_audience { get; set; }
        [DataMember]
        public Int64? premium_video_status { get; set; }
        [DataMember]
        public Int64? premium_video_is_grace_period { get; set; }
        [DataMember]
        public Int64? is_premium_video_sponsor { get; set; }
        [DataMember]
        public string premium_video_sponsor_list { get; set; }
        [DataMember]
        public Int64? technology { get; set; }
        [DataMember]
        public Int64? max_videoconfcall_participants { get; set; }
        [DataMember]
        public Int64? optimal_remote_videos_in_conference { get; set; }
        [DataMember]
        public string message_id { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public string thread_id { get; set; }
        [DataMember]
        public string leg_id { get; set; }
        [DataMember]
        public string conversation_type { get; set; }
        [DataMember]
        public Int64? datachannel_object_id { get; set; }
        [DataMember]
        public string endpoint_details { get; set; }
        [DataMember]
        public string caller_mri_identity { get; set; }
        [DataMember]
        public Int64? member_count_changed { get; set; }
        [DataMember]
        public Int64? transfer_status { get; set; }
        [DataMember]
        public Int64? transfer_failure_reason { get; set; }
        [DataMember]
        public byte[] old_members { get; set; }
        [DataMember]
        public string partner_handle { get; set; }
        [DataMember]
        public string partner_dispname { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? failurereason { get; set; }
        [DataMember]
        public Int64? failurecode { get; set; }
        [DataMember]
        public string pstn_number { get; set; }
        [DataMember]
        public Int64? old_duration { get; set; }
        [DataMember]
        public byte[] conf_participants { get; set; }
        [DataMember]
        public string pstn_status { get; set; }
        [DataMember]
        public byte[] members { get; set; }
        [DataMember]
        public Int64? conv_dbid { get; set; }
        [DataMember]
        public string forwarding_destination_type { get; set; }
        [DataMember]
        public string incoming_type { get; set; }
        [DataMember]
        public string onbehalfof_mri { get; set; }
        [DataMember]
        public string transferor_mri { get; set; }
    }

    [DataContract]
    public class Accounts
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? pwdchangestatus { get; set; }
        [DataMember]
        public Int64? logoutreason { get; set; }
        [DataMember]
        public Int64? commitstatus { get; set; }
        [DataMember]
        public string suggested_skypename { get; set; }
        [DataMember]
        public string skypeout_balance_currency { get; set; }
        [DataMember]
        public Int64? skypeout_balance { get; set; }
        [DataMember]
        public Int64? skypeout_precision { get; set; }
        [DataMember]
        public string skypein_numbers { get; set; }
        [DataMember]
        public string subscriptions { get; set; }
        [DataMember]
        public Int64? cblsyncstatus { get; set; }
        [DataMember]
        public Int64? contactssyncstatus { get; set; }
        [DataMember]
        public string offline_callforward { get; set; }
        [DataMember]
        public Int64? chat_policy { get; set; }
        [DataMember]
        public Int64? skype_call_policy { get; set; }
        [DataMember]
        public Int64? pstn_call_policy { get; set; }
        [DataMember]
        public Int64? avatar_policy { get; set; }
        [DataMember]
        public Int64? buddycount_policy { get; set; }
        [DataMember]
        public Int64? timezone_policy { get; set; }
        [DataMember]
        public Int64? webpresence_policy { get; set; }
        [DataMember]
        public Int64? phonenumbers_policy { get; set; }
        [DataMember]
        public Int64? voicemail_policy { get; set; }
        [DataMember]
        public Int64? authrequest_policy { get; set; }
        [DataMember]
        public Int64? ad_policy { get; set; }
        [DataMember]
        public string partner_optedout { get; set; }
        [DataMember]
        public string service_provider_info { get; set; }
        [DataMember]
        public Int64? registration_timestamp { get; set; }
        [DataMember]
        public Int64? nr_of_other_instances { get; set; }
        [DataMember]
        public string partner_channel_status { get; set; }
        [DataMember]
        public Int64? flamingo_xmpp_status { get; set; }
        [DataMember]
        public Int64? federated_presence_policy { get; set; }
        [DataMember]
        public string liveid_membername { get; set; }
        [DataMember]
        public Int64? roaming_history_enabled { get; set; }
        [DataMember]
        public Int64? cobrand_id { get; set; }
        [DataMember]
        public Int64? shortcircuit_sync { get; set; }
        [DataMember]
        public string signin_name { get; set; }
        [DataMember]
        public Int64? read_receipt_optout { get; set; }
        [DataMember]
        public string hidden_expression_tabs { get; set; }
        [DataMember]
        public Int64? owner_under_legal_age { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public string skypename { get; set; }
        [DataMember]
        public string pstnnumber { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public Int64? birthday { get; set; }
        [DataMember]
        public Int64? gender { get; set; }
        [DataMember]
        public string languages { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string province { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string phone_home { get; set; }
        [DataMember]
        public string phone_office { get; set; }
        [DataMember]
        public string phone_mobile { get; set; }
        [DataMember]
        public string emails { get; set; }
        [DataMember]
        public string homepage { get; set; }
        [DataMember]
        public string about { get; set; }
        [DataMember]
        public Int64? profile_timestamp { get; set; }
        [DataMember]
        public string received_authrequest { get; set; }
        [DataMember]
        public string displayname { get; set; }
        [DataMember]
        public Int64? refreshing { get; set; }
        [DataMember]
        public Int64? given_authlevel { get; set; }
        [DataMember]
        public string aliases { get; set; }
        [DataMember]
        public Int64? authreq_timestamp { get; set; }
        [DataMember]
        public string mood_text { get; set; }
        [DataMember]
        public Int64? timezone { get; set; }
        [DataMember]
        public Int64? nrof_authed_buddies { get; set; }
        [DataMember]
        public string ipcountry { get; set; }
        [DataMember]
        public string given_displayname { get; set; }
        [DataMember]
        public Int64? availability { get; set; }
        [DataMember]
        public Int64? lastonline_timestamp { get; set; }
        [DataMember]
        public byte[] capabilities { get; set; }
        [DataMember]
        public byte[] avatar_image { get; set; }
        [DataMember]
        public string assigned_speeddial { get; set; }
        [DataMember]
        public Int64? lastused_timestamp { get; set; }
        [DataMember]
        public Int64? authrequest_count { get; set; }
        [DataMember]
        public string assigned_comment { get; set; }
        [DataMember]
        public string alertstring { get; set; }
        [DataMember]
        public Int64? avatar_timestamp { get; set; }
        [DataMember]
        public Int64? mood_timestamp { get; set; }
        [DataMember]
        public string rich_mood_text { get; set; }
        [DataMember]
        public byte[] synced_email { get; set; }
        [DataMember]
        public Int64? Set_availability { get; set; }
        [DataMember]
        public byte[] options_change_future { get; set; }
        [DataMember]
        public string msa_pmn { get; set; }
        [DataMember]
        public Int64? authorized_time { get; set; }
        [DataMember]
        public string sent_authrequest { get; set; }
        [DataMember]
        public Int64? sent_authrequest_time { get; set; }
        [DataMember]
        public Int64? sent_authrequest_serial { get; set; }
        [DataMember]
        public byte[] buddyblob { get; set; }
        [DataMember]
        public byte[] cbl_future { get; set; }
        [DataMember]
        public Int64? node_capabilities { get; set; }
        [DataMember]
        public Int64? node_capabilities_and { get; set; }
        [DataMember]
        public Int64? revoked_auth { get; set; }
        [DataMember]
        public Int64? added_in_shared_group { get; set; }
        [DataMember]
        public Int64? in_shared_group { get; set; }
        [DataMember]
        public byte[] authreq_history { get; set; }
        [DataMember]
        public byte[] profile_attachments { get; set; }
        [DataMember]
        public Int64? stack_version { get; set; }
        [DataMember]
        public Int64? offline_authreq_id { get; set; }
        [DataMember]
        public byte[] verified_email { get; set; }
        [DataMember]
        public byte[] verified_company { get; set; }
        [DataMember]
        public Int64? uses_jcs { get; set; }
        [DataMember]
        public Int64? forward_starttime { get; set; }
    }

    [DataContract]
    public class Transfers
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public string partner_handle { get; set; }
        [DataMember]
        public string partner_dispname { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? failurereason { get; set; }
        [DataMember]
        public Int64? starttime { get; set; }
        [DataMember]
        public Int64? finishtime { get; set; }
        [DataMember]
        public string filepath { get; set; }
        [DataMember]
        public string filename { get; set; }
        [DataMember]
        public string filesize { get; set; }
        [DataMember]
        public string bytestransferred { get; set; }
        [DataMember]
        public Int64? bytespersecond { get; set; }
        [DataMember]
        public byte[] chatmsg_guid { get; set; }
        [DataMember]
        public Int64? chatmsg_index { get; set; }
        [DataMember]
        public Int64? convo_id { get; set; }
        [DataMember]
        public Int64? pk_id { get; set; }
        [DataMember]
        public byte[] nodeid { get; set; }
        [DataMember]
        public Int64? last_activity { get; set; }
        [DataMember]
        public Int64? flags { get; set; }
        [DataMember]
        public Int64? old_status { get; set; }
        [DataMember]
        public Int64? old_filepath { get; set; }
        [DataMember]
        public Int64? accepttime { get; set; }
        [DataMember]
        public Int64? parent_id { get; set; }
        [DataMember]
        public string offer_send_list { get; set; }
        [DataMember]
        public string extprop_localfilename { get; set; }
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
        [DataMember]
        public Int64? extprop_window_visible { get; set; }
        [DataMember]
        public Int64? extprop_handled_by_chat { get; set; }
    }

    [DataContract]
    public class Voicemails
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public string partner_handle { get; set; }
        [DataMember]
        public string partner_dispname { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? failurereason { get; set; }
        [DataMember]
        public string subject { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public Int64? duration { get; set; }
        [DataMember]
        public Int64? allowed_duration { get; set; }
        [DataMember]
        public Int64? playback_progress { get; set; }
        [DataMember]
        public Int64? convo_id { get; set; }
        [DataMember]
        public byte[] chatmsg_guid { get; set; }
        [DataMember]
        public Int64? notification_id { get; set; }
        [DataMember]
        public Int64? flags { get; set; }
        [DataMember]
        public Int64? size { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public Int64? failures { get; set; }
        [DataMember]
        public Int64? vflags { get; set; }
        [DataMember]
        public string xmsg { get; set; }
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
    }

    [DataContract]
    public class Chats
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public Int64? options { get; set; }
        [DataMember]
        public string friendlyname { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public Int64? activity_timestamp { get; set; }
        [DataMember]
        public string dialog_partner { get; set; }
        [DataMember]
        public string adder { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? mystatus { get; set; }
        [DataMember]
        public Int64? myrole { get; set; }
        [DataMember]
        public string posters { get; set; }
        [DataMember]
        public string participants { get; set; }
        [DataMember]
        public string applicants { get; set; }
        [DataMember]
        public string banned_users { get; set; }
        [DataMember]
        public string name_text { get; set; }
        [DataMember]
        public string topic { get; set; }
        [DataMember]
        public string topic_xml { get; set; }
        [DataMember]
        public string guidelines { get; set; }
        [DataMember]
        public byte[] picture { get; set; }
        [DataMember]
        public string alertstring { get; set; }
        [DataMember]
        public Int64? is_bookmarked { get; set; }
        [DataMember]
        public string passwordhint { get; set; }
        [DataMember]
        public Int64? unconsumed_suppressed_msg { get; set; }
        [DataMember]
        public Int64? unconsumed_normal_msg { get; set; }
        [DataMember]
        public Int64? unconsumed_elevated_msg { get; set; }
        [DataMember]
        public Int64? unconsumed_msg_voice { get; set; }
        [DataMember]
        public string activemembers { get; set; }
        [DataMember]
        public byte[] state_data { get; set; }
        [DataMember]
        public Int64? lifesigns { get; set; }
        [DataMember]
        public Int64? last_change { get; set; }
        [DataMember]
        public Int64? first_unread_message { get; set; }
        [DataMember]
        public Int64? pk_type { get; set; }
        [DataMember]
        public string dbpath { get; set; }
        [DataMember]
        public string split_friendlyname { get; set; }
        [DataMember]
        public Int64? conv_dbid { get; set; }
    }

    [DataContract]
    public class Messages
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? convo_id { get; set; }
        [DataMember]
        public string chatname { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string from_dispname { get; set; }
        [DataMember]
        public Int64? author_was_live { get; set; }
        [DataMember]
        public byte[] guid { get; set; }
        [DataMember]
        public string dialog_partner { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? sending_status { get; set; }
        [DataMember]
        public Int64? option_bits { get; set; }
        [DataMember]
        public Int64? consumption_status { get; set; }
        [DataMember]
        public string edited_by { get; set; }
        [DataMember]
        public Int64? edited_timestamp { get; set; }
        [DataMember]
        public Int64? param_key { get; set; }
        [DataMember]
        public Int64? param_value { get; set; }
        [DataMember]
        public string body_xml { get; set; }
        [DataMember]
        public string identities { get; set; }
        [DataMember]
        public string reason { get; set; }
        [DataMember]
        public Int64? leavereason { get; set; }
        [DataMember]
        public Int64? participant_count { get; set; }
        [DataMember]
        public Int64? error_code { get; set; }
        [DataMember]
        public Int64? chatmsg_type { get; set; }
        [DataMember]
        public Int64? chatmsg_status { get; set; }
        [DataMember]
        public Int64? body_is_rawxml { get; set; }
        [DataMember]
        public Int64? oldoptions { get; set; }
        [DataMember]
        public Int64? newoptions { get; set; }
        [DataMember]
        public Int64? newrole { get; set; }
        [DataMember]
        public Int64? pk_id { get; set; }
        [DataMember]
        public Int64? crc { get; set; }
        [DataMember]
        public Int64? remote_id { get; set; }
        [DataMember]
        public Int64? server_id { get; set; }
        [DataMember]
        public string call_guid { get; set; }
        [DataMember]
        public Int64? annotation_version { get; set; }
        [DataMember]
        public Int64? timestamp__ms { get; set; }
        [DataMember]
        public string language { get; set; }
        [DataMember]
        public string bots_settings { get; set; }
        [DataMember]
        public string reaction_thread { get; set; }
        [DataMember]
        public Int64? content_flags { get; set; }
        [DataMember]
        public string extprop_contact_review_date { get; set; }
        [DataMember]
        public Int64? extprop_contact_received_stamp { get; set; }
        [DataMember]
        public Int64? extprop_contact_reviewed { get; set; }
    }

    [DataContract]
    public class ContactGroups
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? custom_group_id { get; set; }
        [DataMember]
        public string given_displayname { get; set; }
        [DataMember]
        public Int64? nrofcontacts { get; set; }
        [DataMember]
        public Int64? nrofcontacts_online { get; set; }
        [DataMember]
        public Int64? given_sortorder { get; set; }
        [DataMember]
        public Int64? type_old { get; set; }
        [DataMember]
        public string proposer { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string associated_chat { get; set; }
        [DataMember]
        public string abch_guid { get; set; }
        [DataMember]
        public string members { get; set; }
        [DataMember]
        public Int64? cbl_id { get; set; }
        [DataMember]
        public byte[] cbl_blob { get; set; }
        [DataMember]
        public Int64? @fixed { get; set; }
        [DataMember]
        public Int64? keep_sharedgroup_contacts { get; set; }
        [DataMember]
        public string chats { get; set; }
        [DataMember]
        public Int64? extprop_is_hidden { get; set; }
        [DataMember]
        public Int64? extprop_sortorder_value { get; set; }
        [DataMember]
        public Int64? extprop_is_expanded { get; set; }
    }

    [DataContract]
    public class Videos
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public string error { get; set; }
        [DataMember]
        public string debuginfo { get; set; }
        [DataMember]
        public string dimensions { get; set; }
        [DataMember]
        public Int64? media_type { get; set; }
        [DataMember]
        public Int64? duration_1080 { get; set; }
        [DataMember]
        public Int64? duration_720 { get; set; }
        [DataMember]
        public Int64? duration_hqv { get; set; }
        [DataMember]
        public Int64? duration_vgad2 { get; set; }
        [DataMember]
        public Int64? duration_ltvgad2 { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public Int64? hq_present { get; set; }
        [DataMember]
        public Int64? duration_ss { get; set; }
        [DataMember]
        public Int64? ss_timestamp { get; set; }
        [DataMember]
        public Int64? convo_id { get; set; }
        [DataMember]
        public string device_path { get; set; }
        [DataMember]
        public string device_name { get; set; }
        [DataMember]
        public Int64? participant_id { get; set; }
    }

    [DataContract]
    public class SMSes
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? outgoing_reply_type { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? failurereason { get; set; }
        [DataMember]
        public Int64? error_category { get; set; }
        [DataMember]
        public Int64? is_failed_unseen { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public Int64? price { get; set; }
        [DataMember]
        public Int64? price_precision { get; set; }
        [DataMember]
        public string price_currency { get; set; }
        [DataMember]
        public string reply_to_number { get; set; }
        [DataMember]
        public string target_numbers { get; set; }
        [DataMember]
        public byte[] target_statuses { get; set; }
        [DataMember]
        public string body { get; set; }
        [DataMember]
        public Int64? chatmsg_id { get; set; }
        [DataMember]
        public string identity { get; set; }
        [DataMember]
        public Int64? notification_id { get; set; }
        [DataMember]
        public Int64? event_flags { get; set; }
        [DataMember]
        public string reply_id_number { get; set; }
        [DataMember]
        public string convo_name { get; set; }
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
        [DataMember]
        public Int64? extprop_extended { get; set; }
    }

    [DataContract]
    public class CallMembers
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public string identity { get; set; }
        [DataMember]
        public string dispname { get; set; }
        [DataMember]
        public string languages { get; set; }
        [DataMember]
        public Int64? call_duration { get; set; }
        [DataMember]
        public Int64? price_per_minute { get; set; }
        [DataMember]
        public Int64? price_precision { get; set; }
        [DataMember]
        public string price_currency { get; set; }
        [DataMember]
        public string payment_category { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? failurereason { get; set; }
        [DataMember]
        public Int64? sounderror_code { get; set; }
        [DataMember]
        public Int64? soundlevel { get; set; }
        [DataMember]
        public string pstn_statustext { get; set; }
        [DataMember]
        public string pstn_feedback { get; set; }
        [DataMember]
        public string forward_targets { get; set; }
        [DataMember]
        public string forwarded_by { get; set; }
        [DataMember]
        public string debuginfo { get; set; }
        [DataMember]
        public Int64? videostatus { get; set; }
        [DataMember]
        public string target_identity { get; set; }
        [DataMember]
        public Int64? mike_status { get; set; }
        [DataMember]
        public Int64? is_read_only { get; set; }
        [DataMember]
        public Int64? quality_status { get; set; }
        [DataMember]
        public string call_name { get; set; }
        [DataMember]
        public Int64? transfer_status { get; set; }
        [DataMember]
        public Int64? transfer_active { get; set; }
        [DataMember]
        public string transferred_by { get; set; }
        [DataMember]
        public string transferred_to { get; set; }
        [DataMember]
        public string guid { get; set; }
        [DataMember]
        public Int64? next_redial_time { get; set; }
        [DataMember]
        public Int64? nrof_redials_done { get; set; }
        [DataMember]
        public Int64? nrof_redials_left { get; set; }
        [DataMember]
        public string transfer_topic { get; set; }
        [DataMember]
        public string real_identity { get; set; }
        [DataMember]
        public Int64? start_timestamp { get; set; }
        [DataMember]
        public Int64? is_conference { get; set; }
        [DataMember]
        public string quality_problems { get; set; }
        [DataMember]
        public Int64? identity_type { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public Int64? creation_timestamp { get; set; }
        [DataMember]
        public string stats_xml { get; set; }
        [DataMember]
        public Int64? is_premium_video_sponsor { get; set; }
        [DataMember]
        public Int64? is_multiparty_video_capable { get; set; }
        [DataMember]
        public Int64? recovery_in_progress { get; set; }
        [DataMember]
        public Int64? fallback_in_progress { get; set; }
        [DataMember]
        public string nonse_word { get; set; }
        [DataMember]
        public Int64? nr_of_delivered_push_notifications { get; set; }
        [DataMember]
        public string call_session_guid { get; set; }
        [DataMember]
        public string version_string { get; set; }
        [DataMember]
        public string ip_address { get; set; }
        [DataMember]
        public Int64? is_video_codec_compatible { get; set; }
        [DataMember]
        public Int64? group_calling_capabilities { get; set; }
        [DataMember]
        public string mri_identity { get; set; }
        [DataMember]
        public Int64? is_seamlessly_upgraded_call { get; set; }
        [DataMember]
        public Int64? voicechannel { get; set; }
        [DataMember]
        public Int64? video_count_changed { get; set; }
        [DataMember]
        public Int64? is_active_speaker { get; set; }
        [DataMember]
        public Int64? dominant_speaker_rank { get; set; }
        [DataMember]
        public string participant_sponsor { get; set; }
        [DataMember]
        public Int64? content_sharing_role { get; set; }
        [DataMember]
        public string endpoint_details { get; set; }
        [DataMember]
        public Int64? pk_status { get; set; }
        [DataMember]
        public Int64? call_db_id { get; set; }
        [DataMember]
        public Int64? prime_status { get; set; }
    }

    [DataContract]
    public class ChatMembers
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public string chatname { get; set; }
        [DataMember]
        public string identity { get; set; }
        [DataMember]
        public Int64? role { get; set; }
        [DataMember]
        public Int64? is_active { get; set; }
        [DataMember]
        public Int64? cur_activities { get; set; }
        [DataMember]
        public string adder { get; set; }
    }

    [DataContract]
    public class Alerts
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public string partner_name { get; set; }
        [DataMember]
        public Int64? is_unseen { get; set; }
        [DataMember]
        public Int64? partner_id { get; set; }
        [DataMember]
        public string partner_event { get; set; }
        [DataMember]
        public string partner_history { get; set; }
        [DataMember]
        public string partner_header { get; set; }
        [DataMember]
        public string partner_logo { get; set; }
        [DataMember]
        public Int64? meta_expiry { get; set; }
        [DataMember]
        public string message_header_caption { get; set; }
        [DataMember]
        public string message_header_title { get; set; }
        [DataMember]
        public string message_header_subject { get; set; }
        [DataMember]
        public string message_header_cancel { get; set; }
        [DataMember]
        public string message_header_later { get; set; }
        [DataMember]
        public string message_content { get; set; }
        [DataMember]
        public string message_footer { get; set; }
        [DataMember]
        public string message_button_caption { get; set; }
        [DataMember]
        public string message_button_uri { get; set; }
        [DataMember]
        public Int64? message_type { get; set; }
        [DataMember]
        public Int64? window_size { get; set; }
        [DataMember]
        public byte[] chatmsg_guid { get; set; }
        [DataMember]
        public Int64? notification_id { get; set; }
        [DataMember]
        public Int64? event_flags { get; set; }
        [DataMember]
        public Int64? extprop_hide_from_history { get; set; }
    }

    [DataContract]
    public class Conversations
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public string identity { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public string live_host { get; set; }
        [DataMember]
        public Int64? live_is_hostless { get; set; }
        [DataMember]
        public Int64? live_call_technology { get; set; }
        [DataMember]
        public Int64? optimal_remote_videos_in_conference { get; set; }
        [DataMember]
        public Int64? live_start_timestamp { get; set; }
        [DataMember]
        public Int64? live_is_muted { get; set; }
        [DataMember]
        public Int64? max_videoconfcall_participants { get; set; }
        [DataMember]
        public string alert_string { get; set; }
        [DataMember]
        public Int64? is_bookmarked { get; set; }
        [DataMember]
        public Int64? is_blocked { get; set; }
        [DataMember]
        public string given_displayname { get; set; }
        [DataMember]
        public string displayname { get; set; }
        [DataMember]
        public Int64? local_livestatus { get; set; }
        [DataMember]
        public Int64? inbox_timestamp { get; set; }
        [DataMember]
        public Int64? inbox_message_id { get; set; }
        [DataMember]
        public Int64? last_message_id { get; set; }
        [DataMember]
        public Int64? unconsumed_suppressed_messages { get; set; }
        [DataMember]
        public Int64? unconsumed_normal_messages { get; set; }
        [DataMember]
        public Int64? unconsumed_elevated_messages { get; set; }
        [DataMember]
        public Int64? unconsumed_messages_voice { get; set; }
        [DataMember]
        public Int64? active_vm_id { get; set; }
        [DataMember]
        public Int64? context_horizon { get; set; }
        [DataMember]
        public Int64? consumption_horizon { get; set; }
        [DataMember]
        public Int64? consumption_horizon__ms { get; set; }
        [DataMember]
        public Int64? last_activity_timestamp { get; set; }
        [DataMember]
        public Int64? active_invoice_message { get; set; }
        [DataMember]
        public Int64? spawned_from_convo_id { get; set; }
        [DataMember]
        public Int64? pinned_order { get; set; }
        [DataMember]
        public string creator { get; set; }
        [DataMember]
        public Int64? creation_timestamp { get; set; }
        [DataMember]
        public Int64? my_status { get; set; }
        [DataMember]
        public Int64? opt_joining_enabled { get; set; }
        [DataMember]
        public Int64? opt_moderated { get; set; }
        [DataMember]
        public string opt_access_token { get; set; }
        [DataMember]
        public Int64? opt_entry_level_rank { get; set; }
        [DataMember]
        public Int64? opt_disclose_history { get; set; }
        [DataMember]
        public Int64? opt_history_limit_in_days { get; set; }
        [DataMember]
        public Int64? opt_admin_only_activities { get; set; }
        [DataMember]
        public string passwordhint { get; set; }
        [DataMember]
        public string meta_name { get; set; }
        [DataMember]
        public string meta_topic { get; set; }
        [DataMember]
        public string meta_guidelines { get; set; }
        [DataMember]
        public byte[] meta_picture { get; set; }
        [DataMember]
        public string picture { get; set; }
        [DataMember]
        public Int64? is_p2p_migrated { get; set; }
        [DataMember]
        public Int64? migration_instructions_posted { get; set; }
        [DataMember]
        public Int64? premium_video_status { get; set; }
        [DataMember]
        public Int64? premium_video_is_grace_period { get; set; }
        [DataMember]
        public string guid { get; set; }
        [DataMember]
        public string dialog_partner { get; set; }
        [DataMember]
        public string meta_description { get; set; }
        [DataMember]
        public string premium_video_sponsor_list { get; set; }
        [DataMember]
        public string mcr_caller { get; set; }
        [DataMember]
        public Int64? chat_dbid { get; set; }
        [DataMember]
        public Int64? history_horizon { get; set; }
        [DataMember]
        public string history_sync_state { get; set; }
        [DataMember]
        public string thread_version { get; set; }
        [DataMember]
        public Int64? consumption_horizon_set_at { get; set; }
        [DataMember]
        public string alt_identity { get; set; }
        [DataMember]
        public Int64? in_migrated_thread_since { get; set; }
        [DataMember]
        public string awareness_liveState { get; set; }
        [DataMember]
        public string join_url { get; set; }
        [DataMember]
        public string reaction_thread { get; set; }
        [DataMember]
        public string parent_thread { get; set; }
        [DataMember]
        public Int64? consumption_horizon_rid { get; set; }
        [DataMember]
        public Int64? consumption_horizon_crc { get; set; }
        [DataMember]
        public Int64? consumption_horizon_bookmark { get; set; }
        [DataMember]
        public string client_id { get; set; }
        [DataMember]
        public Int64? last_synced_message_id { get; set; }
        [DataMember]
        public Int64? last_synced_message_version { get; set; }
        [DataMember]
        public Int64? last_synced_days { get; set; }
        [DataMember]
        public Int64? version { get; set; }
        [DataMember]
        public string endpoint_details { get; set; }
        [DataMember]
        public Int64? extprop_profile_height { get; set; }
        [DataMember]
        public Int64? extprop_chat_width { get; set; }
        [DataMember]
        public Int64? extprop_chat_left_margin { get; set; }
        [DataMember]
        public Int64? extprop_chat_right_margin { get; set; }
        [DataMember]
        public Int64? extprop_entry_height { get; set; }
        [DataMember]
        public Int64? extprop_windowpos_x { get; set; }
        [DataMember]
        public Int64? extprop_windowpos_y { get; set; }
        [DataMember]
        public Int64? extprop_windowpos_w { get; set; }
        [DataMember]
        public Int64? extprop_windowpos_h { get; set; }
        [DataMember]
        public Int64? extprop_window_maximized { get; set; }
        [DataMember]
        public Int64? extprop_window_detached { get; set; }
        [DataMember]
        public Int64? extprop_pinned_order { get; set; }
        [DataMember]
        public Int64? extprop_new_in_inbox { get; set; }
        [DataMember]
        public Int64? extprop_tab_order { get; set; }
        [DataMember]
        public Int64? extprop_video_layout { get; set; }
        [DataMember]
        public Int64? extprop_video_chat_height { get; set; }
        [DataMember]
        public Int64? extprop_chat_avatar { get; set; }
        [DataMember]
        public Int64? extprop_consumption_timestamp { get; set; }
        [DataMember]
        public Int64? extprop_form_visible { get; set; }
        [DataMember]
        public Int64? extprop_recovery_mode { get; set; }
        [DataMember]
        public Int64? extprop_translator_enabled { get; set; }
        [DataMember]
        public string extprop_translator_call_my_lang { get; set; }
        [DataMember]
        public string extprop_translator_call_other_lang { get; set; }
        [DataMember]
        public string extprop_translator_chat_my_lang { get; set; }
        [DataMember]
        public string extprop_translator_chat_other_lang { get; set; }
        [DataMember]
        public Int64? extprop_conversation_first_unread_emote { get; set; }
        [DataMember]
        public Int64? datachannel_object_id { get; set; }
        [DataMember]
        public Int64? invite_status { get; set; }
        [DataMember]
        public string highlights_follow_pending { get; set; }
        [DataMember]
        public string highlights_follow_waiting { get; set; }
        [DataMember]
        public string highlights_add_pending { get; set; }
        [DataMember]
        public string highlights_add_waiting { get; set; }
    }

    [DataContract]
    public class Participants
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? convo_id { get; set; }
        [DataMember]
        public string identity { get; set; }
        [DataMember]
        public Int64? rank { get; set; }
        [DataMember]
        public Int64? requested_rank { get; set; }
        [DataMember]
        public Int64? text_status { get; set; }
        [DataMember]
        public Int64? voice_status { get; set; }
        [DataMember]
        public string live_identity { get; set; }
        [DataMember]
        public string live_price_for_me { get; set; }
        [DataMember]
        public string live_fwd_identities { get; set; }
        [DataMember]
        public Int64? live_start_timestamp { get; set; }
        [DataMember]
        public Int64? sound_level { get; set; }
        [DataMember]
        public string debuginfo { get; set; }
        [DataMember]
        public Int64? next_redial_time { get; set; }
        [DataMember]
        public Int64? nrof_redials_left { get; set; }
        [DataMember]
        public string last_voice_error { get; set; }
        [DataMember]
        public string quality_problems { get; set; }
        [DataMember]
        public Int64? live_type { get; set; }
        [DataMember]
        public string live_country { get; set; }
        [DataMember]
        public string transferred_by { get; set; }
        [DataMember]
        public string transferred_to { get; set; }
        [DataMember]
        public string adder { get; set; }
        [DataMember]
        public string sponsor { get; set; }
        [DataMember]
        public Int64? last_leavereason { get; set; }
        [DataMember]
        public Int64? is_premium_video_sponsor { get; set; }
        [DataMember]
        public Int64? is_multiparty_video_capable { get; set; }
        [DataMember]
        public string live_identity_to_use { get; set; }
        [DataMember]
        public Int64? livesession_recovery_in_progress { get; set; }
        [DataMember]
        public Int64? livesession_fallback_in_progress { get; set; }
        [DataMember]
        public Int64? is_multiparty_video_updatable { get; set; }
        [DataMember]
        public string live_ip_address { get; set; }
        [DataMember]
        public Int64? is_video_codec_compatible { get; set; }
        [DataMember]
        public Int64? group_calling_capabilities { get; set; }
        [DataMember]
        public Int64? is_seamlessly_upgraded_call { get; set; }
        [DataMember]
        public Int64? live_voicechannel { get; set; }
        [DataMember]
        public Int64? read_horizon { get; set; }
        [DataMember]
        public Int64? is_active_speaker { get; set; }
        [DataMember]
        public Int64? dominant_speaker_rank { get; set; }
        [DataMember]
        public string endpoint_details { get; set; }
        [DataMember]
        public Int64? messaging_mode { get; set; }
        [DataMember]
        public string real_identity { get; set; }
        [DataMember]
        public Int64? adding_in_progress_since { get; set; }
    }

    [DataContract]
    public class VideoMessages
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public byte[] qik_id { get; set; }
        [DataMember]
        public string attached_msg_ids { get; set; }
        [DataMember]
        public string sharing_id { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? vod_status { get; set; }
        [DataMember]
        public string vod_path { get; set; }
        [DataMember]
        public string local_path { get; set; }
        [DataMember]
        public string public_link { get; set; }
        [DataMember]
        public Int64? progress { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public Int64? creation_timestamp { get; set; }
        [DataMember]
        public string type { get; set; }
    }

    [DataContract]
    public class MediaDocuments
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? storage_document_id { get; set; }
        [DataMember]
        public Int64? sending_status { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public Int64? doc_type { get; set; }
        [DataMember]
        public string uri { get; set; }
        [DataMember]
        public string original_name { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string thumbnail_url { get; set; }
        [DataMember]
        public string web_url { get; set; }
        [DataMember]
        public string mime_type { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string service { get; set; }
        [DataMember]
        public Int64? consumption_status { get; set; }
        [DataMember]
        public Int64? convo_id { get; set; }
        [DataMember]
        public Int64? message_id { get; set; }
        [DataMember]
        public string ams_id { get; set; }
    }

    [DataContract]
    public class Translators
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
    }

    [DataContract]
    public class MessageAnnotations
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? message_id { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public string key { get; set; }
        [DataMember]
        public string @value { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public Int64? timestamp { get; set; }
        [DataMember]
        public Int64? status { get; set; }
    }

    [DataContract]
    public class CallHandlers
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
    }

    [DataContract]
    public class ConversationViews
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? view_id { get; set; }
    }

    [DataContract]
    public class ContentSharings
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? call_id { get; set; }
        [DataMember]
        public string identity { get; set; }
        [DataMember]
        public Int64? status { get; set; }
        [DataMember]
        public string sharing_id { get; set; }
        [DataMember]
        public string state { get; set; }
        [DataMember]
        public Int64? failurereason { get; set; }
        [DataMember]
        public Int64? failurecode { get; set; }
        [DataMember]
        public Int64? failuresubcode { get; set; }
    }

    [DataContract]
    public class DataChannels
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? is_permanent { get; set; }
        [DataMember]
        public Int64? status { get; set; }
    }

    [DataContract]
    public class tracker_journal
    {
        [DataMember, Required]
        public Int64 id { get; set; }
        [DataMember]
        public Int64? dbID { get; set; }
        [DataMember]
        public Int64? type { get; set; }
        [DataMember]
        public Int64? change { get; set; }
    }

    [DataContract]
    public class SkypeMainDbDataSet
    {
        [DataMember]
        public List<DbMeta> DbMetaList { get; set; }
        [DataMember]
        public List<AppSchemaVersion> AppSchemaVersionList { get; set; }
        [DataMember]
        public List<Contacts> ContactsList { get; set; }
        [DataMember]
        public List<LegacyMessages> LegacyMessagesList { get; set; }
        [DataMember]
        public List<Calls> CallsList { get; set; }
        [DataMember]
        public List<Accounts> AccountsList { get; set; }
        [DataMember]
        public List<Transfers> TransfersList { get; set; }
        [DataMember]
        public List<Voicemails> VoicemailsList { get; set; }
        [DataMember]
        public List<Chats> ChatsList { get; set; }
        [DataMember]
        public List<Messages> MessagesList { get; set; }
        [DataMember]
        public List<ContactGroups> ContactGroupsList { get; set; }
        [DataMember]
        public List<Videos> VideosList { get; set; }
        [DataMember]
        public List<SMSes> SMSesList { get; set; }
        [DataMember]
        public List<CallMembers> CallMembersList { get; set; }
        [DataMember]
        public List<ChatMembers> ChatMembersList { get; set; }
        [DataMember]
        public List<Alerts> AlertsList { get; set; }
        [DataMember]
        public List<Conversations> ConversationsList { get; set; }
        [DataMember]
        public List<Participants> ParticipantsList { get; set; }
        [DataMember]
        public List<VideoMessages> VideoMessagesList { get; set; }
        [DataMember]
        public List<MediaDocuments> MediaDocumentsList { get; set; }
        [DataMember]
        public List<Translators> TranslatorsList { get; set; }
        [DataMember]
        public List<MessageAnnotations> MessageAnnotationsList { get; set; }
        [DataMember]
        public List<CallHandlers> CallHandlersList { get; set; }
        [DataMember]
        public List<ConversationViews> ConversationViewsList { get; set; }
        [DataMember]
        public List<ContentSharings> ContentSharingsList { get; set; }
        [DataMember]
        public List<DataChannels> DataChannelsList { get; set; }
        [DataMember]
        public List<tracker_journal> tracker_journalList { get; set; }
    }
}
