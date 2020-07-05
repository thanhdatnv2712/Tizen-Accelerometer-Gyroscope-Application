S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 19866
Date: 2020-05-31 10:58:53+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 19866, uid 5000)

Register Information
r0   = 0x46826dc8, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x413c128a, r5   = 0xbeb8ea80
r6   = 0x4162d6c8, r7   = 0xbeb8eb40
r8   = 0x00000000, r9   = 0x437d14d8
r10  = 0x437ce420, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbeb8ea80
lr   = 0x413c0f89, pc   = 0x413c0f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     16960 KB
Buffers:     29020 KB
Cached:     140932 KB
VmPeak:     114864 KB
VmSize:     112828 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20260 KB
VmRSS:       20256 KB
VmData:      47808 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25396 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19866 TID = 19866
19866 19993 19994 19995 19998 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f3000 4030a000 r-xp /usr/lib/libecore.so.1.7.99
40321000 4037f000 r-xp /usr/lib/libedje.so.1.7.99
40389000 40459000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4045a000 40460000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40468000 4046c000 r-xp /usr/lib/libsmack.so.1.0.0
40475000 4047d000 r-xp /lib/libgcc_s-4.6.so.1
4047e000 405a2000 r-xp /lib/libc-2.13.so
405b0000 405ce000 r-xp /usr/lib/libsystemd.so.0.4.0
405d8000 405e3000 r-xp /lib/libunwind.so.8.0.1
40610000 40627000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062f000 40659000 r-xp /usr/lib/libdbus-1.so.3.8.12
40662000 40667000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066f000 40692000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4069a000 4069b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a3000 406a9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b2000 4071b000 r-xp /lib/libm-2.13.so
40724000 4073d000 r-xp /usr/lib/libeet.so.1.7.99
4074e000 4078f000 r-xp /usr/lib/libeina.so.1.7.99
40798000 407ba000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c3000 407c8000 r-xp /usr/lib/libecore_file.so.1.7.99
407d0000 407e1000 r-xp /usr/lib/libecore_input.so.1.7.99
407e9000 407f2000 r-xp /usr/lib/libvconf.so.0.2.45
407fa000 4084a000 r-xp /usr/lib/libecore_x.so.1.7.99
4084c000 40855000 r-xp /usr/lib/libedbus.so.1.7.99
4085d000 40877000 r-xp /usr/lib/libecore_con.so.1.7.99
40880000 40893000 r-xp /usr/lib/libfribidi.so.0.3.1
4089b000 408e0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e9000 40911000 r-xp /usr/lib/libfontconfig.so.1.8.0
40912000 40968000 r-xp /usr/lib/libfreetype.so.6.11.3
40974000 409ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d7000 409dd000 r-xp /lib/librt-2.13.so
409e6000 409ed000 r-xp /usr/lib/libembryo.so.1.7.99
409f5000 40a0c000 r-xp /usr/lib/liblua-5.1.so
40a15000 40a1b000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a23000 40a24000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2c000 40a5b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a63000 40a66000 r-xp /lib/libcap.so.2.21
40a6e000 40a86000 r-xp /usr/lib/liblzma.so.5.0.3
40a8e000 40a9e000 r-xp /lib/libresolv-2.13.so
40aa2000 40b75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b80000 40bb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbd000 40bd7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bdf000 40c54000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5e000 40c60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c68000 40c7e000 r-xp /lib/libz.so.1.2.5
40c86000 40ca9000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc1000 40da2000 r-xp /usr/lib/libX11.so.6.3.0
40dad000 40db2000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dbb000 40dbf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc8000 40dcb000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd3000 40dda000 r-xp /usr/lib/libXcursor.so.1.0.2
40de2000 40de4000 r-xp /usr/lib/libXdamage.so.1.1.0
40dec000 40dee000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df6000 40df8000 r-xp /usr/lib/libXgesture.so.7.0.0
40e00000 40e03000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0b000 40e14000 r-xp /usr/lib/libXi.so.6.1.0
40e1c000 40e1d000 r-xp /usr/lib/libXinerama.so.1.0.0
40e26000 40e2c000 r-xp /usr/lib/libXrandr.so.2.2.0
40e34000 40e3a000 r-xp /usr/lib/libXrender.so.1.3.0
40e42000 40e46000 r-xp /usr/lib/libXtst.so.6.1.0
40e4e000 40e58000 r-xp /usr/lib/libXext.so.6.4.0
40e61000 40ea5000 r-xp /usr/lib/libcurl.so.4.3.0
40eae000 40ec4000 r-xp /lib/libexpat.so.1.6.0
40ece000 40ee6000 r-xp /usr/lib/libpng12.so.0.50.0
40eee000 40f0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f14000 40fa8000 r-xp /usr/lib/libstdc++.so.6.0.16
40fbb000 40fbe000 r-xp /lib/libattr.so.1.1.0
40fc6000 40fc7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fcf000 40fd4000 r-xp /usr/lib/libffi.so.5.0.10
40fdd000 40fdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe7000 410b3000 r-xp /usr/lib/libxml2.so.2.7.8
410c0000 410c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410cb000 410cd000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d5000 410e8000 r-xp /usr/lib/libxcb.so.1.1.0
410f2000 410fb000 r-xp /usr/lib/libcares.so.2.1.0
41104000 41132000 r-xp /usr/lib/libidn.so.11.5.44
4113a000 41181000 r-xp /usr/lib/libssl.so.1.0.0
4118d000 4131f000 r-xp /usr/lib/libcrypto.so.1.0.0
41341000 41343000 r-xp /usr/lib/libiri.so
4134b000 41352000 r-xp /lib/libcrypt-2.13.so
41382000 41384000 r-xp /usr/lib/libXau.so.6.0.0
41391000 41395000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139d000 413a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a7000 413ac000 r-xp /usr/lib/libappcore-common.so.1.1
413b4000 413b6000 r-xp /usr/lib/libiniparser.so.0
413bf000 413c2000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
413d5000 413d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e2000 413e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ed000 413f3000 r-xp /usr/lib/libappsvc.so.0.1.0
413fb000 4141f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41428000 414f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
41510000 41513000 rw-p [heap]
41513000 41534000 rw-p [heap]
41534000 4153e000 r-xp /lib/libnss_files-2.13.so
417db000 417e6000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
417f1000 417fd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
41806000 41827000 r-xp /usr/lib/libefl-extension.so.0.1.0
4182f000 41859000 r-xp /usr/lib/libsensor.so.1.9.7
41862000 41869000 r-xp /usr/lib/libctx-shared.so.0.8.3
41871000 41876000 r-xp /usr/lib/libctx-client.so.0.8.3
4187e000 41890000 r-xp /usr/lib/libefl-assist.so.0.1.0
41898000 41950000 r-xp /usr/lib/libcairo.so.2.11200.14
4195b000 41965000 r-xp /usr/lib/libsensord-shared.so
4196e000 4197d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41986000 4199c000 r-xp /usr/lib/libtts.so
419a5000 419c8000 r-xp /usr/lib/libui-extension.so.0.1.0
419d1000 419dc000 r-xp /usr/lib/libtbm.so.1.0.0
419e4000 419f2000 r-xp /usr/lib/libGLESv2.so.2.0
419fb000 419fc000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a05000 41a0b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a13000 41a16000 r-xp /usr/lib/libEGL.so.1.4
41a1e000 41a23000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a2b000 41a2e000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a36000 41a37000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a40000 41bc8000 r-xp /usr/lib/libicui18n.so.57.1
41bd8000 41cde000 r-xp /usr/lib/libicuuc.so.57.1
41cf4000 41cfc000 r-xp /usr/lib/libdrm.so.2.4.0
41d04000 41d06000 r-xp /usr/lib/libdri2.so.0.0.0
41d0e000 41d14000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d1c000 41d21000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d29000 41d42000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435e3000 43604000 r-xp /usr/lib/libexif.so.12.3.3
43617000 43619000 r-xp /usr/lib/libttrace.so.1.1
43621000 43626000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4362e000 43634000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4363d000 43645000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4364d000 4366f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43678000 4367f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43688000 4368a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43692000 43699000 r-xp /usr/lib/libminizip.so.1.0.0
436a1000 436ae000 r-xp /usr/lib/libail.so.0.1.0
436b7000 436bd000 r-xp /usr/lib/libproc-stat.so.0.2.96
436c5000 436c6000 r-xp /usr/lib/libresponse.so.0.2.96
436ce000 436d3000 r-xp /usr/lib/libsystem.so.0.0.0
437dd000 438a7000 r-xp /usr/lib/libCOREGL.so.4.0
43c18000 43c23000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c2c000 43c31000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c39000 43c50000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c5d000 43c5f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
447ac000 44fab000 rw-p [stack:19993]
44fac000 457ab000 rw-p [stack:19994]
457ac000 45fab000 rw-p [stack:19995]
45fac000 467ab000 rw-p [stack:19998]
467ab000 467ac000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
467ca000 467d2000 r-xp /usr/lib/libfeedback.so.0.1.4
467d4000 467d5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
467dd000 467df000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
467e7000 467f2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
4697f000 46986000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4698e000 469a6000 r-xp /usr/lib/libmmfsound.so.0.1.0
469b7000 469bb000 r-xp /usr/lib/libmmfsession.so.0.0.0
469c4000 469cf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
469dc000 469e0000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
469e8000 469fe000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46a06000 46a67000 r-xp /usr/lib/libasound.so.2.0.0
46a71000 46a74000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46a7c000 46ab4000 r-xp /usr/lib/libpulse.so.0.16.2
46ab5000 46ab8000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46ac0000 46b09000 r-xp /usr/lib/libmdm.so.1.2.70
46b12000 46b15000 r-xp /usr/lib/libtinycompress.so.0.0.0
46b1d000 46b22000 r-xp /usr/lib/libjson.so.0.0.1
46b2a000 46b73000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46b7c000 46bc3000 r-xp /usr/lib/libsndfile.so.1.0.26
46bcf000 46bdf000 r-xp /usr/lib/libmdm-common.so.1.1.25
46be7000 46c09000 r-xp /usr/lib/libvorbis.so.0.4.3
46c11000 46c15000 r-xp /usr/lib/libogg.so.0.7.1
beb82000 bec7a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19866)
Call Stack Count: 18
 0: save_data + 0x7d (0x413c0f8a) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1f8a
 1: _button_click_cb + 0x148 (0x413c0c51) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1c51
 2: evas_object_smart_callback_call + 0x88 (0x402345cd) [/usr/lib/libevas.so.1] + 0x355cd
 3: (0x40366f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 4: (0x4036aefd) [/usr/lib/libedje.so.1] + 0x49efd
 5: (0x40367869) [/usr/lib/libedje.so.1] + 0x46869
 6: (0x40367c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 7: (0x40367d55) [/usr/lib/libedje.so.1] + 0x46d55
 8: (0x402fe3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 9: (0x402fbe53) [/usr/lib/libecore.so.1] + 0x8e53
10: (0x402ff46b) [/usr/lib/libecore.so.1] + 0xc46b
11: ecore_main_loop_begin + 0x30 (0x402ff879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41393421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x12e (0x413c0477) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1477
15: register_gyroscope_callback + 0x1e (0x40001a53) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1a53
16: __libc_start_main + 0x114 (0x4049585c) [/lib/libc.so.6] + 0x1785c
17: accelerometer_cb + 0x137 (0x40001e0c) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1e0c
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
3): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
05-31 10:58:48.890+0700 E/W_INDICATOR(  713): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
05-31 10:58:48.890+0700 W/W_INDICATOR(  713): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
05-31 10:58:48.940+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
05-31 10:58:48.940+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[gesture],charge : 0, connected : 0
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [starter:org.tizen.idled.ReservedApp]
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:org.tizen.idled.ReservedApp]
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 10:58:48.945+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:48.950+0700 W/STARTER (  711): clock-mgr.c: __reserved_apps_message_received_cb(586) > [__reserved_apps_message_received_cb:586] appid[com.samsung.windicator]
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.windicator:org.tizen.idled.ReservedApp]
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 10:58:48.950+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:48.950+0700 W/W_INDICATOR(  713): windicator_dbus.c: _msg_reserved_app_cb(336) > [_msg_reserved_app_cb:336] Moment view is already shown or call is enabled. moment view [-1]
05-31 10:58:48.990+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 0[0;m
05-31 10:58:48.990+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
05-31 10:58:48.990+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:48.990+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(pedometer_goal_achieve_percents) error
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(best_step_goal) error
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(host_pedo_default_goal), check retry err: -21/(2/No such file or directory).
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(host_pedo_default_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:48.995+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(host_pedo_default_goal) error
05-31 10:58:48.995+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:58:49.005+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:58:49.030+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [4990][0;m
05-31 10:58:49.040+0700 W/SHealthServiceCommon( 1277): PedometerSensorProxy.cpp: SOnContextPedometerUpdated(171) > [1;35mpedometerMode: 0[0;m
05-31 10:58:49.070+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 0[0;m
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(pedometer_goal_achieve_percents) error
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(best_step_goal) error
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(host_pedo_default_goal), check retry err: -21/(2/No such file or directory).
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(host_pedo_default_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:49.070+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(host_pedo_default_goal) error
05-31 10:58:49.070+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:58:49.085+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:58:49.310+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:58:49.310+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:58:49.310+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:58:49.310+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:58:49.310+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:58:49.310+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:58:49.310+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:58:49.320+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 1 -> 2
05-31 10:58:49.325+0700 E/wnoti-service(  878): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 1 to 2 
05-31 10:58:49.330+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
05-31 10:58:49.330+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:552> }
05-31 10:58:49.345+0700 E/EFL     (18501): ecore_x<18501> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18632445 button=1
05-31 10:58:49.365+0700 W/SHealthServiceCommon( 1277): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
05-31 10:58:49.460+0700 E/EFL     (18501): ecore_x<18501> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18632564 button=1
05-31 10:58:49.710+0700 W/CRASH_MANAGER(19898): worker.c: worker_job(1205) > 11185016261731590897529
05-31 10:58:49.880+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (3)
05-31 10:58:49.880+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(3)
05-31 10:58:49.880+0700 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 10:58:49.880+0700 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 10:58:49.880+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(fg) type(uiapp)
05-31 10:58:49.905+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18501 pgid = 18501
05-31 10:58:49.905+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-31 10:58:49.910+0700 E/RESOURCED(  584): block-monitor.c: block_logging(123) > pid 18501(67014 18l) accessed /opt/usr/media/Downloads/data-2020-5-31_10-58-36.txt
05-31 10:58:50.000+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-31 10:58:50.005+0700 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18501
05-31 10:58:50.005+0700 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18501)
05-31 10:58:50.065+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 10:58:50.065+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-31 10:58:50.065+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-31 10:58:50.065+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:58:50.065+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:58:50.065+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:58:50.065+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:58:50.065+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:58:50.070+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
05-31 10:58:50.070+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.070+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.075+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.075+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
05-31 10:58:50.075+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:58:50.075+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:58:50.100+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(0)
05-31 10:58:50.100+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
05-31 10:58:50.100+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.100+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.100+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(0)
05-31 10:58:50.100+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: RESUME State: PAUSED
05-31 10:58:50.100+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 10:58:50.100+0700 W/W_HOME  (  970): main.c: _appcore_resume_cb(480) > appcore resume
05-31 10:58:50.100+0700 W/W_HOME  (  970): event_manager.c: _app_resume_cb(373) > state: 2 -> 1
05-31 10:58:50.100+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.105+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:58:50.105+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:58:50.105+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.105+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:50.105+0700 W/APPS    (  970): apps_main.c: _time_changed_cb(409) >  date : 31->31
05-31 10:58:50.105+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:58:50.105+0700 W/W_HOME  (  970): rotary.c: rotary_attach(138) > rotary_attach:0x46b6f488
05-31 10:58:50.105+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46b6f488, elm_layout, _activated_obj : 0x460c2aa8, activated : 1
05-31 10:58:50.105+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 10:58:50.105+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:58:50.105+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:58:50.110+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
05-31 10:58:50.110+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 10:58:50.110+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-31 10:58:50.625+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed95b8] swap changed from async to sync
05-31 10:58:50.755+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
05-31 10:58:50.775+0700 W/SHealthServiceCommon( 1277): PedometerSensorProxy.cpp: SOnContextPedometerUpdated(171) > [1;35mpedometerMode: 0[0;m
05-31 10:58:50.790+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 0[0;m
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(pedometer_goal_achieve_percents) error
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(best_step_goal) error
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
05-31 10:58:50.795+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(host_pedo_default_goal), check retry err: -21/(2/No such file or directory).
05-31 10:58:50.800+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(host_pedo_default_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:58:50.800+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(host_pedo_default_goal) error
05-31 10:58:50.800+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:58:50.820+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:58:51.110+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:58:51.110+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:51.110+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:58:51.110+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 10:58:51.110+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 10:58:51.110+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 10:58:51.115+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 10:58:51.115+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 10:58:51.115+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 10:58:51.115+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 10:58:51.115+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 10:58:51.115+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 10:58:51.880+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18634983 button=1
05-31 10:58:51.880+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.880+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.880+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [279, 134]
05-31 10:58:51.880+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 10:58:51.895+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.900+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.910+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.920+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.940+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.950+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.975+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:58:51.985+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18635092 button=1
05-31 10:58:51.985+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [279, 134]->[274, 140]
05-31 10:58:51.985+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[16], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:58:51.985+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,16]
05-31 10:58:51.990+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 10:58:51.990+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(502) >  item(basicui) launched, open(0), tts(0)
05-31 10:58:51.990+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.basicui)
05-31 10:58:51.990+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:58:51.995+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:58:51.995+0700 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-31 10:58:52.005+0700 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.basicui, table num : 6
05-31 10:58:52.010+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 10:58:52.010+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 10:58:52.010+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 10:58:52.015+0700 W/AUL_PAD (19866): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 10:58:52.015+0700 W/AUL_PAD (19866): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 10:58:52.015+0700 W/AUL_PAD (19866): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 10:58:52.015+0700 W/AUL_PAD (19866): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.basicui)
05-31 10:58:52.060+0700 I/efl-extension(19866): efl_extension.c: eext_mod_init(40) > Init
05-31 10:58:52.065+0700 I/UXT     (19866): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 10:58:52.070+0700 W/AUL_PAD (19866): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 10:58:52.070+0700 W/AUL_PAD (19866): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.basicui)
05-31 10:58:52.070+0700 I/CAPI_APPFW_APPLICATION(19866): app_main.c: ui_app_main(704) > app_efl_main
05-31 10:58:52.075+0700 I/CAPI_APPFW_APPLICATION(19866): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 10:58:52.115+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.basicui) pid(19866) type(uiapp) bg(0)
05-31 10:58:52.115+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19866)
05-31 10:58:52.115+0700 W/W_HOME  (  970): util.c: apps_util_launch_main_operation(785) > Launch app:[basicui] ret:[0]
05-31 10:58:52.115+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (19866) was created
05-31 10:58:52.115+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 10:58:52.115+0700 W/W_HOME  (  970): util.c: send_launch_appId(620) > launch appid[org.example.basicui]
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 10:58:52.120+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: IsPreloaded(395) > _MessagePortService::IsPreloaded
05-31 10:58:52.135+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [19866]
05-31 10:58:52.170+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 10:58:52.180+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:52.180+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(536) >  appid(org.example.basicui)  pkgid(org.example.basicui), name(basicui)
05-31 10:58:52.195+0700 E/EFL     (19866): ecore_evas<19866> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 10:58:52.220+0700 E/EFL     (19866): elementary<19866> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-31 10:58:52.265+0700 E/EFL     (19866): elementary<19866> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x436f0a68) will be pushed
05-31 10:58:52.295+0700 I/basicui (19866): started
05-31 10:58:52.320+0700 I/basicui (19866): started
05-31 10:58:52.330+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: _setWidgetContentInfo(1582) >  0x45924078, org.example.collectpro|17|0 com.samsung.shealth|12|0 com.samsung.w-gallery|16|0 org.example.sensorapp|15|0 org.example.basicui|24|0 org.example.collectdata|14|0, 24
05-31 10:58:52.330+0700 I/CAPI_WIDGET_APPLICATION(13571): widget_app.c: __provider_update_cb(281) > received updating signal
05-31 10:58:52.350+0700 I/APP_CORE(19866): appcore-efl.c: __do_app(453) > [APP 19866] Event: RESET State: CREATED
05-31 10:58:52.350+0700 I/CAPI_APPFW_APPLICATION(19866): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 10:58:52.355+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 10:58:52.355+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.355+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.355+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.355+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:58:52.355+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 10:58:52.365+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:58:52.370+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:58:52.410+0700 I/APP_CORE(19866): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 10:58:52.415+0700 I/APP_CORE(19866): appcore-efl.c: __do_app(524) > [APP 19866] Initial Launching, call the resume_cb
05-31 10:58:52.415+0700 I/CAPI_APPFW_APPLICATION(19866): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 10:58:52.425+0700 W/APP_CORE(19866): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5a00002
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.470+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 10:58:52.470+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 10:58:52.470+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 10:58:52.470+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.470+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:58:52.470+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 10:58:52.470+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 10:58:52.470+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:58:52.475+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 10:58:52.475+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 10:58:52.480+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 10:58:52.485+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[19866] goes to (3)
05-31 10:58:52.485+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:58:52.485+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.basicui) pid(19866) status(fg) type(uiapp)
05-31 10:58:52.505+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [basicui:16] Focused[1], focusIdx[16]
05-31 10:58:52.505+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:sensorcollector], focusIdx[16]
05-31 10:58:52.505+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:58:52.520+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:58:52.520+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:58:52.520+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:58:52.525+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:58:52.525+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 10:58:52.525+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 10:58:52.535+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 10:58:52.535+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 10:58:52.535+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 10:58:52.535+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 10:58:52.535+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 10:58:52.535+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 10:58:52.535+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 10:58:52.535+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 10:58:52.535+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 10:58:52.535+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 10:58:52.545+0700 I/APP_CORE(19866): appcore-efl.c: __do_app(453) > [APP 19866] Event: RESUME State: RUNNING
05-31 10:58:52.565+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 10:58:52.880+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 10:58:52.905+0700 E/EFL     (19866): ecore_x<19866> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18636011 button=1
05-31 10:58:53.015+0700 E/EFL     (19866): ecore_x<19866> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18636120 button=1
05-31 10:58:53.035+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 10:58:53.235+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 10:58:53.245+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19866
05-31 10:58:53.245+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 10:58:53.770+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 10:58:53.785+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19866
05-31 10:58:53.820+0700 E/EFL     (19866): ecore_x<19866> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18636927 button=1
05-31 10:58:53.935+0700 E/EFL     (19866): ecore_x<19866> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18637038 button=1
05-31 10:58:53.960+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 10:58:53.970+0700 I/AUL_PAD (20001): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 10:58:54.135+0700 W/CRASH_MANAGER(19898): worker.c: worker_job(1205) > 1119866626173159089753
