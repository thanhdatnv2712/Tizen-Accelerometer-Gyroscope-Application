S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 22296
Date: 2020-05-31 11:15:35+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 22296, uid 5000)

Register Information
r0   = 0x44ef31f8, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x4000228a, r5   = 0xbe9f8a60
r6   = 0x44bb01d0, r7   = 0xbe9f8b20
r8   = 0x00000000, r9   = 0x44ee99c8
r10  = 0x44ee68a8, fp   = 0x00000001
ip   = 0x432d7034, sp   = 0xbe9f8a60
lr   = 0x40001f89, pc   = 0x40001f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     30992 KB
Buffers:     15056 KB
Cached:     138796 KB
VmPeak:     132988 KB
VmSize:     132072 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20308 KB
VmRSS:       20308 KB
VmData:      65272 KB
VmStk:        1008 KB
VmExe:          12 KB
VmLib:       27112 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 7
PID = 22296 TID = 22296
22296 22301 22302 22310 22311 22312 22315 

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
40005000 40009000 r-xp /usr/lib/libsys-assert.so
40013000 40030000 r-xp /lib/ld-2.13.so
40039000 40044000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4004f000 40053000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005b000 40067000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
40070000 40078000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
40079000 4007b000 r-xp /usr/lib/libdlog.so.0.0.0
40083000 400a4000 r-xp /usr/lib/libefl-extension.so.0.1.0
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f3000 40417000 r-xp /lib/libc-2.13.so
40425000 4042d000 r-xp /lib/libgcc_s-4.6.so.1
4042e000 40439000 r-xp /lib/libunwind.so.8.0.1
40466000 40468000 r-xp /lib/libdl-2.13.so
40471000 40475000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4047e000 40480000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40489000 4048f000 r-xp /usr/lib/libappcore-efl.so.1.1
40497000 4049c000 r-xp /usr/lib/libappcore-common.so.1.1
404a4000 404b1000 r-xp /usr/lib/libaul.so.0.1.0
404bb000 404de000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404e6000 40527000 r-xp /usr/lib/libeina.so.1.7.99
40530000 40544000 r-xp /lib/libpthread-2.13.so
4054f000 40579000 r-xp /usr/lib/libsensor.so.1.9.7
40582000 40589000 r-xp /usr/lib/libctx-shared.so.0.8.3
40591000 40596000 r-xp /usr/lib/libctx-client.so.0.8.3
4059e000 40632000 r-xp /usr/lib/libstdc++.so.6.0.16
40645000 406ae000 r-xp /lib/libm-2.13.so
406b7000 40707000 r-xp /usr/lib/libecore_x.so.1.7.99
40709000 4072b000 r-xp /usr/lib/libecore_evas.so.1.7.99
40734000 4073d000 r-xp /usr/lib/libvconf.so.0.2.45
40745000 4076d000 r-xp /usr/lib/libfontconfig.so.1.8.0
4076e000 4083a000 r-xp /usr/lib/libxml2.so.2.7.8
40847000 40917000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40918000 4092a000 r-xp /usr/lib/libefl-assist.so.0.1.0
40932000 40949000 r-xp /usr/lib/libecore.so.1.7.99
40960000 409be000 r-xp /usr/lib/libedje.so.1.7.99
409c8000 40a80000 r-xp /usr/lib/libcairo.so.2.11200.14
40a8b000 40b6c000 r-xp /usr/lib/libX11.so.6.3.0
40b77000 40b80000 r-xp /usr/lib/libXi.so.6.1.0
40b88000 40ba1000 r-xp /usr/lib/libeet.so.1.7.99
40bb2000 40bb7000 r-xp /usr/lib/libecore_file.so.1.7.99
40bbf000 40bd0000 r-xp /usr/lib/libecore_input.so.1.7.99
40bd8000 40be1000 r-xp /usr/lib/libedbus.so.1.7.99
40be9000 40c13000 r-xp /usr/lib/libdbus-1.so.3.8.12
40c1c000 40c36000 r-xp /usr/lib/libecore_con.so.1.7.99
40c3f000 40c52000 r-xp /usr/lib/libfribidi.so.0.3.1
40c5a000 40c9f000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40ca8000 40cfe000 r-xp /usr/lib/libfreetype.so.6.11.3
40d0a000 40d60000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d6d000 40d73000 r-xp /usr/lib/libappsvc.so.0.1.0
40d7b000 40d7e000 r-xp /usr/lib/libbundle.so.0.1.22
40d87000 40d8d000 r-xp /usr/lib/libecore_imf.so.1.7.99
40d95000 40dc9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40dd2000 40dd4000 r-xp /usr/lib/libiniparser.so.0
40ddd000 40df4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40dfc000 40e01000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e0a000 40e0b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40e13000 40e31000 r-xp /usr/lib/libsystemd.so.0.4.0
40e3b000 40e55000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e5d000 40ed2000 r-xp /usr/lib/libsqlite3.so.0.8.6
40edc000 40ee2000 r-xp /lib/librt-2.13.so
40eec000 40fbf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40fca000 40fd0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40fd9000 40fe3000 r-xp /usr/lib/libsensord-shared.so
40fec000 40ffb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41004000 41033000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
4103c000 41043000 r-xp /usr/lib/libXcursor.so.1.0.2
4104b000 4104d000 r-xp /usr/lib/libXdamage.so.1.1.0
41055000 41057000 r-xp /usr/lib/libXcomposite.so.1.0.0
4105f000 41061000 r-xp /usr/lib/libXgesture.so.7.0.0
41069000 4106c000 r-xp /usr/lib/libXfixes.so.3.1.0
41075000 41076000 r-xp /usr/lib/libXinerama.so.1.0.0
4107f000 41085000 r-xp /usr/lib/libXrandr.so.2.2.0
4108d000 41093000 r-xp /usr/lib/libXrender.so.1.3.0
4109b000 4109f000 r-xp /usr/lib/libXtst.so.6.1.0
410a7000 410b1000 r-xp /usr/lib/libXext.so.6.4.0
410ba000 410bf000 r-xp /usr/lib/libecore_fb.so.1.7.99
410c9000 410cd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
410d6000 410d9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
410e1000 410f7000 r-xp /lib/libexpat.so.1.6.0
41101000 41117000 r-xp /lib/libz.so.1.2.5
4111f000 41135000 r-xp /usr/lib/libtts.so
4113f000 41162000 r-xp /usr/lib/libui-extension.so.0.1.0
4116b000 41176000 r-xp /usr/lib/libtbm.so.1.0.0
4117e000 41185000 r-xp /usr/lib/libembryo.so.1.7.99
4118d000 411a4000 r-xp /usr/lib/liblua-5.1.so
411ad000 411ae000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
411b7000 411c5000 r-xp /usr/lib/libGLESv2.so.2.0
411ce000 411e6000 r-xp /usr/lib/libpng12.so.0.50.0
411ee000 411ef000 r-xp /usr/lib/libxcb-shm.so.0.0.0
411f8000 411fe000 r-xp /usr/lib/libxcb-render.so.0.0.0
41206000 41219000 r-xp /usr/lib/libxcb.so.1.1.0
41222000 41225000 r-xp /usr/lib/libEGL.so.1.4
4122e000 41251000 r-xp /usr/lib/libjpeg.so.8.0.2
41269000 412ad000 r-xp /usr/lib/libcurl.so.4.3.0
412b6000 412b7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
412bf000 412c4000 r-xp /usr/lib/libffi.so.5.0.10
412cd000 412cf000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
412d7000 412ef000 r-xp /usr/lib/liblzma.so.5.0.3
412f7000 41307000 r-xp /lib/libresolv-2.13.so
4130b000 4130d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41316000 41318000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41321000 41323000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
4132b000 4132f000 r-xp /usr/lib/libsmack.so.1.0.0
41338000 41355000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4135e000 41363000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4136c000 4136f000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41377000 41378000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41381000 41509000 r-xp /usr/lib/libicui18n.so.57.1
41519000 4161f000 r-xp /usr/lib/libicuuc.so.57.1
41635000 4163d000 r-xp /usr/lib/libdrm.so.2.4.0
41646000 41648000 r-xp /usr/lib/libdri2.so.0.0.0
41650000 41652000 r-xp /usr/lib/libXau.so.6.0.0
4165a000 41663000 r-xp /usr/lib/libcares.so.2.1.0
4166c000 4169a000 r-xp /usr/lib/libidn.so.11.5.44
416a2000 416e9000 r-xp /usr/lib/libssl.so.1.0.0
416f6000 41888000 r-xp /usr/lib/libcrypto.so.1.0.0
418a9000 418ab000 r-xp /usr/lib/libiri.so
418b3000 418b6000 r-xp /lib/libcap.so.2.21
418be000 418c5000 r-xp /lib/libcrypt-2.13.so
418f5000 418fb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41904000 41909000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41911000 4192a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431cb000 431ce000 r-xp /lib/libattr.so.1.1.0
431d7000 431f8000 r-xp /usr/lib/libexif.so.12.3.3
4320b000 4320d000 r-xp /usr/lib/libttrace.so.1.1
43215000 4321a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43222000 43228000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43231000 43239000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43242000 43264000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4326d000 43274000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4327d000 4327f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43287000 4328e000 r-xp /usr/lib/libminizip.so.1.0.0
43296000 432a3000 r-xp /usr/lib/libail.so.0.1.0
432ad000 432b3000 r-xp /usr/lib/libproc-stat.so.0.2.96
432bb000 432bc000 r-xp /usr/lib/libresponse.so.0.2.96
432c4000 432c9000 r-xp /usr/lib/libsystem.so.0.0.0
433d9000 434a3000 r-xp /usr/lib/libCOREGL.so.4.0
434b5000 434d9000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
434e2000 435b1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
435c7000 435d1000 r-xp /lib/libnss_files-2.13.so
43939000 439ae000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
439be000 43b07000 r-xp /usr/lib/egl/libMali.so
43b14000 43b19000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b2a000 43b2d000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43b36000 44335000 rw-p [stack:22301]
44336000 44b35000 rw-p [stack:22302]
44deb000 44e02000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44f0f000 44f11000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45961000 46160000 rw-p [stack:22310]
46161000 46960000 rw-p [stack:22311]
46961000 47260000 rw-p [stack:22312]
47261000 47a60000 rw-p [stack:22315]
47b24000 47b25000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
47b43000 47b4b000 r-xp /usr/lib/libfeedback.so.0.1.4
47b4d000 47b4e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
47b56000 47b58000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
47b60000 47b6b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
47b73000 47b7a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
47b82000 47b9a000 r-xp /usr/lib/libmmfsound.so.0.1.0
47bab000 47baf000 r-xp /usr/lib/libmmfsession.so.0.0.0
47bb8000 47bc3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
47bd0000 47bd4000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
47bdc000 47bf2000 r-xp /usr/lib/libavsysaudio.so.0.0.1
47d00000 47d61000 r-xp /usr/lib/libasound.so.2.0.0
47d6b000 47d6e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
47d76000 47dae000 r-xp /usr/lib/libpulse.so.0.16.2
47daf000 47db2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
47dba000 47e03000 r-xp /usr/lib/libmdm.so.1.2.70
47e0c000 47e0f000 r-xp /usr/lib/libtinycompress.so.0.0.0
47e17000 47e1c000 r-xp /usr/lib/libjson.so.0.0.1
47e24000 47e6d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
47e76000 47ebd000 r-xp /usr/lib/libsndfile.so.1.0.26
47ec9000 47ed9000 r-xp /usr/lib/libmdm-common.so.1.1.25
47ee1000 47f03000 r-xp /usr/lib/libvorbis.so.0.4.3
47f0b000 47f0f000 r-xp /usr/lib/libogg.so.0.7.1
be9ec000 beae4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22296)
Call Stack Count: 17
 0: save_data + 0x7d (0x40001f8a) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1f8a
 1: _button_click_cb + 0x148 (0x40001c51) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1c51
 2: evas_object_smart_callback_call + 0x88 (0x402345cd) [/usr/lib/libevas.so.1] + 0x355cd
 3: (0x409a5f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 4: (0x409a9efd) [/usr/lib/libedje.so.1] + 0x49efd
 5: (0x409a6869) [/usr/lib/libedje.so.1] + 0x46869
 6: (0x409a6c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 7: (0x409a6d55) [/usr/lib/libedje.so.1] + 0x46d55
 8: (0x4093d3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 9: (0x4093ae53) [/usr/lib/libecore.so.1] + 0x8e53
10: (0x4093e46b) [/usr/lib/libecore.so.1] + 0xc46b
11: ecore_main_loop_begin + 0x30 (0x4093e879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x4048cb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x40051421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x12e (0x40001477) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1477
15: __libc_start_main + 0x114 (0x4030a85c) [/lib/libc.so.6] + 0x1785c
16: (0x400011c0) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x11c0
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
isable back gesture
05-31 11:15:35.695+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:15:35.695+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
05-31 11:15:35.695+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:15:35.695+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-31 11:15:35.720+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:15:35.745+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:15:35.745+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:15:36.210+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed95b8] swap changed from async to sync
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:15:36.695+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:15:36.695+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:15:36.700+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:15:36.715+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:15:36.715+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:15:36.715+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:15:36.720+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:15:36.720+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:15:36.720+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:15:36.720+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:15:36.720+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:15:36.720+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:15:37.310+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19640414 button=1
05-31 11:15:37.310+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.310+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.310+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [250, 73]
05-31 11:15:37.310+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 11:15:37.330+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.340+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.350+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.405+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.425+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.440+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.450+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.470+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:15:37.505+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19640610 button=1
05-31 11:15:37.505+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [250, 73]->[249, 78]
05-31 11:15:37.505+0700 E/APPS    (  970): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6941) >  Can't Find AppsItem at [-1]
05-31 11:15:37.505+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[0], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[1], HideNextPage[0], ItemListSize[18]
05-31 11:15:37.505+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 11:15:37.505+0700 W/APPS    (  970): AppsViewNecklace.cpp: onClickedRecentApps(3256) >  item(Ứng dụng gần đây) launched, open(0)
05-31 11:15:37.505+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-taskmanager)
05-31 11:15:37.505+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:15:37.510+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:15:37.510+0700 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-31 11:15:37.530+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 11:15:37.530+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 11:15:37.530+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 11:15:37.550+0700 E/EFL     (  461): elementary<461> elm_widget.c:4382 elm_widget_type_check() Passing Object: 0x45c6ae70 in function: elm_layout_edje_get, of type: 'edje' when expecting type: 'elm_layout'
05-31 11:15:37.550+0700 E/UXT     (  461): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(41) > failed to get edje from parent object.
05-31 11:15:37.555+0700 W/AUL     (22270): smack_util.c: set_app_smack_label(242) > thr_cnt: 2, signal count: 2,  try count 1, launchpad type: 1
05-31 11:15:37.555+0700 W/AUL_PAD (22270): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 11:15:37.555+0700 W/AUL_PAD (22270): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 11:15:37.555+0700 W/AUL_PAD (22270): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 11:15:37.555+0700 W/AUL_PAD (22270): launchpad_loader.c: main(680) > [candidate] dlopen(com.samsung.w-taskmanager)
05-31 11:15:37.560+0700 E/EFL     (  461): ecore_evas<461> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 11:15:37.605+0700 W/AUL_PAD (22270): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 11:15:37.605+0700 W/AUL_PAD (22270): launchpad_loader.c: main(694) > [candidate] dl_main(com.samsung.w-taskmanager)
05-31 11:15:37.605+0700 I/CAPI_APPFW_APPLICATION(22270): app_main.c: app_efl_main(129) > app_efl_main
05-31 11:15:37.610+0700 I/CAPI_APPFW_APPLICATION(22270): app_main.c: app_appcore_create(152) > app_appcore_create
05-31 11:15:37.630+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-taskmanager) pid(22270) type(uiapp) bg(0)
05-31 11:15:37.630+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (22270) was created
05-31 11:15:37.635+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:15:37.635+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22270)
05-31 11:15:37.635+0700 W/W_HOME  (  970): util.c: apps_util_launch_main_operation(785) > Launch app:[Ứng dụng gần đây] ret:[0]
05-31 11:15:37.635+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [22270]
05-31 11:15:37.635+0700 W/W_HOME  (  970): util.c: send_launch_appId(620) > launch appid[com.samsung.w-taskmanager]
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 11:15:37.635+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: IsPreloaded(395) > _MessagePortService::IsPreloaded
05-31 11:15:37.690+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:15:37.690+0700 E/W_HOME  (  970): util.c: send_launch_appId(636) > There is no remote message port
05-31 11:15:37.695+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ed95b8] swap changed from sync to async
05-31 11:15:37.850+0700 I/APP_CORE(22270): appcore-efl.c: __do_app(453) > [APP 22270] Event: RESET State: CREATED
05-31 11:15:37.850+0700 I/CAPI_APPFW_APPLICATION(22270): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-31 11:15:37.940+0700 I/efl-extension(22270): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
05-31 11:15:37.940+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-31 11:15:37.940+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-31 11:15:37.940+0700 I/efl-extension(22270): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-31 11:15:37.945+0700 I/efl-extension(22270): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-31 11:15:37.945+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45470630, elm_image, _activated_obj : 0x0, activated : 1
05-31 11:15:37.955+0700 E/CAPI_MEDIA_CONTROLLER(  876): media_controller_main.c: __mc_main_check_connection(34) > [0m[No-error] Timer is Called but there is working Process, connection_cnt = 1
05-31 11:15:37.980+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
05-31 11:15:37.980+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
05-31 11:15:37.980+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
05-31 11:15:37.985+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
05-31 11:15:37.985+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
05-31 11:15:37.985+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
05-31 11:15:38.000+0700 E/W_TASKMANAGER(22270): util_wc1.c: close_button_disabled_set(375) > [close_button_disabled_set:375] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-31 11:15:38.030+0700 E/W_TASKMANAGER(22270): task.c: _app_list_cb(499) > [_app_list_cb:499] pkgmgrinfo_appinfo_get_label(com.samsung.skmsa) failed(0)
05-31 11:15:38.035+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:15:38.035+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (health-data-service)!!
05-31 11:15:38.035+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.w-home)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.wusvc)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.shealth-service)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.wnotiboard-popup)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.watchface-service)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.weip.consumer)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.idle-clock-heartrate01)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.wcl-widget)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.shealth.widget.pedometer)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.alm-widget)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.app-shortcut-widget)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.w-magazine-service-slave)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.w-gallery.consumer)!!
05-31 11:15:38.040+0700 E/W_TASKMANAGER(22270): task.c: _iterfunc(531) > [_iterfunc:531] Fail to get ai table (com.samsung.w-taskmanager)!!
05-31 11:15:38.045+0700 E/RUA     (22270): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 38, ncols : 5
05-31 11:15:38.060+0700 E/EFL     (22270): evas_main<22270> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0x454cfd80 not inside same smart as 0x454a77a8!
05-31 11:15:38.060+0700 E/EFL     (22270): elementary<22270> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x454827c0 into part 'elm.swallow.event.0'
05-31 11:15:38.090+0700 I/APP_CORE(22270): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 11:15:38.090+0700 I/APP_CORE(22270): appcore-efl.c: __do_app(524) > [APP 22270] Initial Launching, call the resume_cb
05-31 11:15:38.090+0700 I/CAPI_APPFW_APPLICATION(22270): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 11:15:38.115+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 11:15:38.115+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.115+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.115+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.115+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:15:38.115+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 11:15:38.115+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:15:38.150+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:15:38.150+0700 W/APP_CORE(22270): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00003
05-31 11:15:38.180+0700 I/MALI    (22270): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
05-31 11:15:38.195+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:15:38.215+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 11:15:38.215+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 11:15:38.215+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 11:15:38.215+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.215+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 11:15:38.215+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.215+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 11:15:38.215+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 11:15:38.215+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[22270] goes to (3)
05-31 11:15:38.220+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 11:15:38.220+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:15:38.220+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 11:15:38.220+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 11:15:38.220+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.220+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(22270) status(fg) type(uiapp)
05-31 11:15:38.220+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:15:38.220+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.220+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:38.220+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 11:15:38.220+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:15:38.240+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:15:38.240+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:15:38.240+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:15:38.245+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:15:38.245+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:15:38.245+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:15:38.250+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:15:38.250+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:15:38.250+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:15:38.250+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:15:38.250+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:15:38.250+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:15:38.250+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:15:38.250+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 11:15:38.250+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:15:38.250+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 11:15:38.250+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:15:38.260+0700 I/APP_CORE(22270): appcore-efl.c: __do_app(453) > [APP 22270] Event: RESUME State: RUNNING
05-31 11:15:38.285+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 11:15:38.290+0700 I/MALI    (22270): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x41d07210] swap changed from async to sync
05-31 11:15:38.725+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:15:38.730+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22270
05-31 11:15:38.735+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:15:38.740+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22270
05-31 11:15:38.740+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:15:38.745+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:15:38.750+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 11:15:39.035+0700 I/APP_CORE(  713): appcore-efl.c: __do_app(453) > [APP 713] Event: MEM_FLUSH State: PAUSED
05-31 11:15:40.635+0700 I/efl-extension(22388): efl_extension.c: eext_mod_init(40) > Init
05-31 11:15:40.760+0700 E/EFL     (22270): ecore_x<22270> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19643864 button=1
05-31 11:15:40.845+0700 I/UXT     (22388): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 11:15:40.900+0700 E/EFL     (22270): ecore_x<22270> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19644006 button=1
05-31 11:15:41.160+0700 I/AUL_PAD (22388): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 11:15:41.270+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:15:41.285+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
05-31 11:15:41.300+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 22
05-31 11:15:41.300+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(999) > app status : 4
05-31 11:15:41.300+0700 E/APP_CORE(22270): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
05-31 11:15:41.300+0700 I/APP_CORE(22270): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
05-31 11:15:41.300+0700 I/APP_CORE(22270): appcore-efl.c: __after_loop(1234) > [APP 22270] PAUSE before termination
05-31 11:15:41.300+0700 I/CAPI_APPFW_APPLICATION(22270): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:15:41.300+0700 I/CAPI_APPFW_APPLICATION(22270): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-31 11:15:41.300+0700 I/efl-extension(22270): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x45451c68, obj: 0x45451c68
05-31 11:15:41.300+0700 I/efl-extension(22270): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
05-31 11:15:41.300+0700 I/efl-extension(22270): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
05-31 11:15:41.300+0700 I/efl-extension(22270): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
05-31 11:15:41.300+0700 I/efl-extension(22270): efl_extension_rotary.c: _object_deleted_cb(618) > done
05-31 11:15:41.305+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
05-31 11:15:41.305+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] cw(0), ch(0), pw(360), ph(360)
05-31 11:15:41.305+0700 E/EFL     (22270): elementary<22270> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x45451c68 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x45470630
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x4545f098 is freed
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45451c68, elm_scroller, func : 0x4393d379
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45470630, elm_image, func : 0x4393d379
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 11:15:41.305+0700 I/efl-extension(22270): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x45451c68 : elm_scroller] rotary callabck is deleted
05-31 11:15:41.325+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (3)
05-31 11:15:41.325+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(3)
05-31 11:15:41.330+0700 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 11:15:41.330+0700 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 11:15:41.330+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(fg) type(uiapp)
05-31 11:15:41.330+0700 I/APP_CORE(22270): appcore-efl.c: __after_loop(1243) > [APP 22270] After terminate() callback
05-31 11:15:41.340+0700 E/MALI    (22388): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
05-31 11:15:41.340+0700 I/MALI    (22270): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x41d07210] swap changed from sync to async
05-31 11:15:41.340+0700 E/MALI    (22270): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
05-31 11:15:41.360+0700 I/MALI    (22270): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
05-31 11:15:41.360+0700 I/MALI    (22270): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=22270   close drm_fd=22 
05-31 11:15:41.360+0700 I/MALI    (22270): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
05-31 11:15:41.365+0700 E/MALI    (22388): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
05-31 11:15:41.365+0700 E/MALI    (22388): [gpu-ddk] devel/graphics_drv/r4p0
05-31 11:15:41.365+0700 E/MALI    (22388): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
05-31 11:15:41.365+0700 E/MALI    (22388): [coregl] devel/graphics_engine/master
05-31 11:15:41.365+0700 E/MALI    (22388): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
05-31 11:15:41.365+0700 E/MALI    (22388): K
05-31 11:15:41.515+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 11:15:41.520+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-31 11:15:41.520+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-31 11:15:41.520+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:15:41.520+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:15:41.520+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:15:41.520+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:15:41.520+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:15:41.550+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
05-31 11:15:41.550+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.550+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.555+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.555+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
05-31 11:15:41.555+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:15:41.570+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:15:41.600+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(0)
05-31 11:15:41.600+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
05-31 11:15:41.600+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.600+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.600+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(0)
05-31 11:15:41.605+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: RESUME State: PAUSED
05-31 11:15:41.605+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 11:15:41.605+0700 W/W_HOME  (  970): main.c: _appcore_resume_cb(480) > appcore resume
05-31 11:15:41.605+0700 W/W_HOME  (  970): event_manager.c: _app_resume_cb(373) > state: 2 -> 1
05-31 11:15:41.605+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.605+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.605+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:15:41.605+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:15:41.615+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:15:41.615+0700 W/APPS    (  970): apps_main.c: _time_changed_cb(409) >  date : 31->31
05-31 11:15:41.615+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 11:15:41.615+0700 W/W_HOME  (  970): rotary.c: rotary_attach(138) > rotary_attach:0x46b6f488
05-31 11:15:41.615+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46b6f488, elm_layout, _activated_obj : 0x460c2aa8, activated : 1
05-31 11:15:41.615+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:15:41.620+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:15:41.620+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:15:41.620+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
05-31 11:15:41.620+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:15:41.620+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-31 11:15:41.855+0700 I/UXT     (22270): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
05-31 11:15:41.855+0700 I/UXT     (22270): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
05-31 11:15:41.855+0700 I/UXT     (22270): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
05-31 11:15:42.070+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed95b8] swap changed from async to sync
05-31 11:15:42.160+0700 W/AUL_PAD (22270): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
05-31 11:15:42.165+0700 I/efl-extension(22270): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-31 11:15:42.320+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 22270 pgid = 22270
05-31 11:15:42.320+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
05-31 11:15:42.410+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-31 11:15:42.415+0700 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22270
05-31 11:15:42.415+0700 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22270)
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:15:42.620+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:15:42.620+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:15:42.625+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:15:42.625+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:15:42.625+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:15:42.625+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:15:42.630+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:15:42.630+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:15:42.630+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:15:42.630+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:15:42.630+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:15:42.630+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:15:43.300+0700 W/AUL_AMD (  507): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
05-31 11:15:45.580+0700 W/CRASH_MANAGER(22403): worker.c: worker_job(1205) > 1122296626173159089853
