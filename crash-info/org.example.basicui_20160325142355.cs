S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 10887
Date: 2016-03-25 14:23:55+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xbf0074b8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbf007478, esi = 0xb45fd623
ebp = 0xbfe01498, esp = 0xbfe013d0
eax = 0xb97974a0, ebx = 0xb45feb58
ecx = 0xb45feb58, edx = 0xb45fd5e2
eip = 0xb45fd278

Memory Information
MemTotal:      124 KB
MemFree:        20 KB
Buffers:        16 KB
Cached:     164824 KB
VmPeak:      71944 KB
VmSize:      71944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14384 KB
VmRSS:       14384 KB
VmData:      11592 KB
VmStk:         992 KB
VmExe:          28 KB
VmLib:       31800 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10887 TID = 10887
10887 10891 

Maps Information
b35dd000 b35de000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b35df000 b35e1000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b35e2000 b3606000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b37a8000 b37ab000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b37ac000 b37ba000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b37bb000 b37ca000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3fd1000 b3fd4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3fd5000 b3fd8000 r-xp /usr/lib/libdri2.so.0.0.0
b3fd9000 b3fe4000 r-xp /usr/lib/libdrm.so.2.4.0
b3fe5000 b3fee000 r-xp /usr/lib/libtbm.so.1.0.0
b3fef000 b3ff6000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3ff7000 b4000000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4001000 b4008000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4009000 b400f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4010000 b4018000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4019000 b401d000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b401e000 b403b000 r-xp /usr/lib/libtts.so
b403c000 b4180000 r-xp /usr/lib/libcairo.so.2.11200.14
b4184000 b419c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b419d000 b41be000 r-xp /usr/lib/libefl-extension.so.0.1.0
b41bf000 b41cf000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b41d0000 b41db000 r-xp /lib/libnss_files-2.13.so
b441c000 b4443000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4444000 b4469000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b446a000 b458b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b459b000 b45d1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b45d3000 b45d6000 r-xp /usr/lib/libiniparser.so.0
b45d8000 b45e2000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b45e3000 b45ec000 r-xp /usr/lib/libappsvc.so.0.1.0
b45ed000 b45f0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45f1000 b45f3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45f4000 b45fa000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b45fb000 b45fe000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b45ff000 b4605000 r-xp /usr/lib/libogg.so.0.7.1
b4606000 b4631000 r-xp /usr/lib/libvorbis.so.0.4.3
b4632000 b471d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b472b000 b472d000 r-xp /usr/lib/libXau.so.6.0.0
b472e000 b478e000 r-xp /usr/lib/libssl.so.1.0.0
b4793000 b47c4000 r-xp /usr/lib/libidn.so.11.5.44
b47c5000 b47d5000 r-xp /usr/lib/libcares.so.2.1.0
b47d6000 b483f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4845000 b484f000 r-xp /usr/lib/libsensord-share.so
b4850000 b4876000 r-xp /lib/libexpat.so.1.5.2
b4878000 b489f000 r-xp /usr/lib/libpng12.so.0.50.0
b48a0000 b48c0000 r-xp /usr/lib/libxcb.so.1.1.0
b48c1000 b4930000 r-xp /usr/lib/libcurl.so.4.3.0
b4932000 b493d000 r-xp /usr/lib/libethumb.so.1.7.99
b5e9d000 b5f75000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f81000 b5f84000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f85000 b5f9b000 r-xp /usr/lib/libremix.so.0.0.0
b5f9c000 b5f9e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f9f000 b5fcb000 r-xp /usr/lib/liblua-5.1.so
b5fcc000 b5fd6000 r-xp /usr/lib/libembryo.so.1.7.99
b5fd7000 b601d000 r-xp /usr/lib/libjpeg.so.8.0.2
b602e000 b604c000 r-xp /usr/lib/libsensor.so.1.1.0
b604e000 b60d0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b60d5000 b6109000 r-xp /usr/lib/libfontconfig.so.1.5.0
b610b000 b6166000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6168000 b617e000 r-xp /usr/lib/libfribidi.so.0.3.1
b617f000 b620b000 r-xp /usr/lib/libfreetype.so.6.11.3
b620f000 b6212000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6213000 b6219000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b621a000 b6220000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6222000 b6233000 r-xp /usr/lib/libXext.so.6.4.0
b6234000 b6368000 r-xp /usr/lib/libX11.so.6.3.0
b636c000 b6371000 r-xp /usr/lib/libXtst.so.6.1.0
b6372000 b637a000 r-xp /usr/lib/libXrender.so.1.3.0
b637b000 b6384000 r-xp /usr/lib/libXrandr.so.2.2.0
b6385000 b6387000 r-xp /usr/lib/libXinerama.so.1.0.0
b6388000 b6396000 r-xp /usr/lib/libXi.so.6.1.0
b6397000 b639b000 r-xp /usr/lib/libXfixes.so.3.1.0
b639c000 b639e000 r-xp /usr/lib/libXgesture.so.7.0.0
b639f000 b63a1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b63a2000 b63a4000 r-xp /usr/lib/libXdamage.so.1.1.0
b63a5000 b63ae000 r-xp /usr/lib/libXcursor.so.1.0.2
b63af000 b63da000 r-xp /usr/lib/libecore_con.so.1.7.99
b63dc000 b63e4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63e5000 b63f0000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63f1000 b63f7000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63f8000 b6419000 r-xp /usr/lib/libefreet.so.1.7.99
b641b000 b6427000 r-xp /usr/lib/libedbus.so.1.7.99
b6428000 b6587000 r-xp /usr/lib/libicuuc.so.51.1
b6595000 b679e000 r-xp /usr/lib/libicui18n.so.51.1
b67a7000 b6844000 r-xp /usr/lib/libedje.so.1.7.99
b6846000 b6857000 r-xp /usr/lib/libecore_input.so.1.7.99
b6858000 b685f000 r-xp /usr/lib/libecore_file.so.1.7.99
b6860000 b6886000 r-xp /usr/lib/libeet.so.1.7.99
b688f000 b69b7000 r-xp /usr/lib/libevas.so.1.7.99
b69d4000 b6a07000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6a09000 b6a4d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a4f000 b6c49000 r-xp /usr/lib/libelementary.so.1.7.99
b6c5a000 b6c60000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c61000 b6c65000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c69000 b6c6a000 r-xp /usr/lib/libjournal.so.0.1.0
b6c6b000 b6db3000 r-xp /usr/lib/libxml2.so.2.7.8
b6dba000 b6dcd000 r-xp /lib/libresolv-2.13.so
b6dd1000 b6dee000 r-xp /lib/libz.so.1.2.5
b6def000 b6df2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6df3000 b6df8000 r-xp /usr/lib/libffi.so.5.0.10
b6df9000 b6dfa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dfc000 b6e00000 r-xp /lib/libattr.so.1.1.0
b6e01000 b7013000 r-xp /usr/lib/libcrypto.so.1.0.0
b702e000 b704f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b7050000 b7078000 r-xp /lib/libm-2.13.so
b707a000 b70d5000 r-xp /usr/lib/libeina.so.1.7.99
b70d8000 b70e3000 r-xp /usr/lib/libvconf.so.0.2.45
b70e4000 b70e7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70e8000 b7136000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7137000 b7298000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b729c000 b72a3000 r-xp /lib/librt-2.13.so
b72a6000 b72ad000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b72af000 b72c9000 r-xp /lib/libgcc_s-4.6.4.so.1
b72ca000 b72d2000 r-xp /lib/libcrypt-2.13.so
b72fb000 b72ff000 r-xp /lib/libcap.so.2.21
b7300000 b7302000 r-xp /usr/lib/libiri.so
b7304000 b7330000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7331000 b7351000 r-xp /usr/lib/libecore.so.1.7.99
b7360000 b7369000 r-xp /usr/lib/libxdgmime.so.1.1.0
b736a000 b748d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b748e000 b74a1000 r-xp /usr/lib/libail.so.0.1.0
b74a3000 b74c8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b74c9000 b74d3000 r-xp /lib/libunwind.so.8.0.1
b74dd000 b764e000 r-xp /lib/libc-2.13.so
b7654000 b769e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b769f000 b76a4000 r-xp /usr/lib/libbundle.so.0.1.22
b76a5000 b76a8000 r-xp /lib/libdl-2.13.so
b76ab000 b76b0000 r-xp /usr/lib/libsmack.so.1.0.0
b76b1000 b7759000 r-xp /usr/lib/libsqlite3.so.0.8.6
b775c000 b7776000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7777000 b778e000 r-xp /lib/libpthread-2.13.so
b7792000 b7795000 r-xp /usr/lib/libdlog.so.0.0.0
b7796000 b77a6000 r-xp /usr/lib/libaul.so.0.1.0
b77a8000 b77ae000 r-xp /usr/lib/libappcore-common.so.1.1
b77af000 b77b4000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b6000 b77bb000 r-xp /usr/lib/libsys-assert.so
b77be000 b77dc000 r-xp /lib/ld-2.13.so
b77dc000 b77dd000 r-xp [vdso]
b77df000 b77e6000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:10887)
Call Stack Count: 9
 0: save_data + 0x118 (0xb45fd278) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x2278
 1: create_base_gui + 0x594 (0xb45fcd84) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1d84
 2: app_create + 0x31 (0xb45fc651) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1651
 3: (0xb6c623cf) [/usr/lib/libcapi-appfw-application.so.0] + 0x13cf
 4: appcore_efl_main + 0x293 (0xb77b1d53) [/usr/lib/libappcore-efl.so.1] + 0x2d53
 5: ui_app_main + 0x130 (0xb6c635f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
 6: main + 0x337 (0xb45fc5a7) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x15a7
 7: (0xb77e25b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77e25b1
 8: __libc_start_main + 0xf3 (0xb74f60f3) [/lib/libc.so.6] + 0x190f3
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
dle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 60
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-25 14:23:49.515+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:60
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 60
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[60]
03-25 14:23:49.515+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.basicui
03-25 14:23:49.515+0900 D/APPS    ( 2311): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 60
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.515+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.525+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
03-25 14:23:49.525+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 1
03-25 14:23:49.525+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 1
03-25 14:23:49.525+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 1
03-25 14:23:49.525+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 1
03-25 14:23:49.525+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 1
03-25 14:23:49.535+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 1
03-25 14:23:49.545+0900 E/PKGMGR_CERT(10826): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_make_directory(1586) > mkdir failed. appdir=[/usr/apps/org.example.basicui/shared], errno=[2][No such file or directory]
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared]
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.basicui/shared/res]
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/tizen-manifest.xml]
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/author-signature.xml]
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.basicui/signature1.xml]
03-25 14:23:49.545+0900 E/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/share/packages/org.example.basicui.xml]
03-25 14:23:49.545+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-25 14:23:49.565+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.basicui), result=[0]
03-25 14:23:49.565+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui, 5, _), result=[0]
03-25 14:23:49.565+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared, 5, _), result=[0]
03-25 14:23:49.565+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/res, 5, _), result=[0]
03-25 14:23:49.585+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/data, 2), result=[0]
03-25 14:23:49.595+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_get_group_id(1866) > encoding done, len=[28]
03-25 14:23:49.595+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_apply_smack(1974) > groupid = [682QedHw7g5Hf0gJXcIO5I3Okls=] for shared/trusted.
03-25 14:23:49.605+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/shared/trusted, 1, 682QedHw7g5Hf0gJXcIO5I3Okls=), result=[0]
03-25 14:23:49.605+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/bin, 0, org.example.basicui), result=[0]
03-25 14:23:49.605+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/lib, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/res, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/tizen-manifest.xml, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/author-signature.xml, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/usr/apps/org.example.basicui/signature1.xml, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/share/packages/org.example.basicui.xml, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui, 5, _), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/data, 0, org.example.basicui), result=[0]
03-25 14:23:49.615+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/cache, 0, org.example.basicui), result=[0]
03-25 14:23:49.625+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared, 5, _), result=[0]
03-25 14:23:49.645+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.basicui, /opt/storage/sdcard/apps/org.example.basicui/shared/data, 2), result=[0]
03-25 14:23:49.665+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.basicui] version set to [2.3.1] result=[0]
03-25 14:23:49.665+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_package_install(2330) > api-version fot privilege has done successfully.
03-25 14:23:49.675+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/appmanager.launch]
03-25 14:23:49.675+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.675+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.705+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.705+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.705+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/content.write]
03-25 14:23:49.705+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.715+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.725+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.725+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.725+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage]
03-25 14:23:49.735+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.735+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.755+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.755+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.755+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/externalstorage.appdata]
03-25 14:23:49.755+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.755+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.775+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.775+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1106) > it is EXT_APPDATA_PRIVILEGE_NAME
03-25 14:23:49.775+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.basicui/shared/data])
03-25 14:23:49.775+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.775+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/internet]
03-25 14:23:49.785+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.785+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.805+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.805+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.805+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/mediastorage]
03-25 14:23:49.805+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.815+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.825+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.825+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.825+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.basicui], privilege = [http://tizen.org/privilege/network.get]
03-25 14:23:49.835+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.835+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.845+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.845+0900 D/rpm-installer(10826): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.basicui, 7) succeed.
03-25 14:23:49.855+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
03-25 14:23:49.855+0900 D/rpm-installer(10826): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.basicui, 7), result=[0]
03-25 14:23:49.875+0900 D/rpm-installer(10826): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
03-25 14:23:49.875+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_package_install(2340) > permission applying done successfully.
03-25 14:23:49.875+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
03-25 14:23:49.875+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/appmanager.launch
03-25 14:23:49.875+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.875+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.875+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.875+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/content.write
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/externalstorage.appdata
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/internet
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/mediastorage
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/network.get
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
03-25 14:23:49.885+0900 D/PRIVILEGE_MANAGER(10826): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
03-25 14:23:49.885+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_verify_privilege_list(741) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
03-25 14:23:49.885+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_package_install(2348) > _coretpk_installer_verify_privilege_list done.
03-25 14:23:49.885+0900 D/rpm-installer(10826): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.basicui], key=[install_percent], val=[100]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/DATA_PROVIDER_MASTER( 2335): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.basicui] 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/ADD_VIEWER( 2311): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.basicui] 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:install_percent val:100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / install_percent / 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[install_percent] val[100]
03-25 14:23:49.895+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.basicui
03-25 14:23:49.895+0900 D/APPS    ( 2311): pkgmgr.c: _install_percent(469) >  package(org.example.basicui) with 100
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_package_install(2370) > install status is [2].
03-25 14:23:49.895+0900 D/rpm-installer(10826): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
03-25 14:23:49.895+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_package_install(2382) > _coretpk_installer_package_install is done.
03-25 14:23:49.895+0900 D/rpm-installer(10826): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.basicui], key=[end], val=[ok]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2300): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2435): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.895+0900 D/DATA_PROVIDER_MASTER( 2335): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.basicui] ok
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2335): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.895+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.905+0900 D/ADD_VIEWER( 2311): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.basicui] ok
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.905+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:end val:ok
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.905+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.905+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.basicui
03-25 14:23:49.905+0900 D/APPS    ( 2311): pkgmgr.c: _end(651) >  Package(org.example.basicui) : key(update) - val(ok)
03-25 14:23:49.905+0900 D/APPS    ( 2311): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.basicui]
03-25 14:23:49.905+0900 D/APPS    ( 2311): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.basicui]'s item object
03-25 14:23:49.905+0900 D/APPS    ( 2311): db.c: apps_db_remove_item(404) >  Remove the item[org.example.basicui]
03-25 14:23:49.905+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.905+0900 D/PKGMGR  ( 2173): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.915+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584 / coretpk / org.example.basicui / end / ok
03-25 14:23:49.915+0900 D/PKGMGR  ( 2226): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_-997284584] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-25 14:23:49.915+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.basicui), key(end), value(ok)
03-25 14:23:49.915+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
03-25 14:23:49.915+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-25 14:23:49.915+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.basicui, comp:ui, type:rpm
03-25 14:23:49.915+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.915+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.915+0900 D/rpm-installer(10826): coretpk-installer.c: _coretpk_installer_prepare_package_install(2872) > success
03-25 14:23:49.915+0900 D/rpm-installer(10826): rpm-appcore-intf.c: main(224) > sync() start
03-25 14:23:49.925+0900 E/PKGMGR_INFO( 2173): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-25 14:23:49.935+0900 D/APPS    ( 2311): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-25 14:23:49.935+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:49.935+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:49.935+0900 D/APPS    ( 2311): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-25 14:23:49.935+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-25 14:23:49.945+0900 D/rpm-installer(10826): rpm-appcore-intf.c: main(226) > sync() end
03-25 14:23:49.945+0900 D/rpm-installer(10826): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-25 14:23:49.945+0900 D/rpm-installer(10826): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-25 14:23:49.945+0900 D/rpm-installer(10826): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-25 14:23:49.945+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-25 14:23:49.955+0900 D/BADGE   ( 2335): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-25 14:23:49.955+0900 E/DATA_PROVIDER_MASTER( 2335): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-25 14:23:49.955+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2335, fd: -1
03-25 14:23:49.955+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2335), fd: -1
03-25 14:23:49.955+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 32 (recv_fd: -1)
03-25 14:23:49.955+0900 D/APPS    ( 2311): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-25 14:23:49.955+0900 D/PKGMGR_SERVER(10817): pkgmgr-server.c: sighandler(326) > child exit [10826]
03-25 14:23:49.955+0900 D/PKGMGR_SERVER(10817): pkgmgr-server.c: sighandler(341) > child NORMAL exit [10826]
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-25 14:23:49.955+0900 D/BADGE   ( 2335): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-25 14:23:49.955+0900 E/DATA_PROVIDER_MASTER( 2335): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-25 14:23:49.955+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2335, fd: -1
03-25 14:23:49.955+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2335), fd: -1
03-25 14:23:49.955+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 32 (recv_fd: -1)
03-25 14:23:49.955+0900 D/APPS    ( 2311): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-25 14:23:49.955+0900 D/COM_CORE( 2335): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c0daf0 is terminated (NIL packet)
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-25 14:23:49.955+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-25 14:23:49.965+0900 D/APPS    ( 2311): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-25 14:23:49.965+0900 D/COM_CORE( 2335): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-25 14:23:49.965+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c0d9d0 is terminated (NIL packet)
03-25 14:23:49.965+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-25 14:23:49.975+0900 D/BADGE   ( 2311): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-25 14:23:49.975+0900 D/APPS    ( 2311): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-25 14:23:49.975+0900 D/APPS    ( 2311): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 1
03-25 14:23:49.975+0900 D/APPS    ( 2311): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-25 14:23:49.985+0900 D/APPS    ( 2311): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:1]
03-25 14:23:50.005+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-25 14:23:50.005+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-25 14:23:50.995+0900 D/PKGMGR_SERVER(10817): pkgmgr-server.c: exit_server(724) > exit_server Start
03-25 14:23:50.995+0900 D/PKGMGR_SERVER(10817): pkgmgr-server.c: main(1516) > Quit main loop.
03-25 14:23:50.995+0900 D/PKGMGR_SERVER(10817): pkgmgr-server.c: main(1524) > package manager server terminated.
03-25 14:23:55.095+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-25 14:23:55.095+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-25 14:23:55.105+0900 D/AUL     ( 2226): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 10884, pid = 10886
03-25 14:23:55.105+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-25 14:23:55.105+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1785) > process_pool: false
03-25 14:23:55.105+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-25 14:23:55.105+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-25 14:23:55.105+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-25 14:23:55.105+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-25 14:23:55.105+0900 D/AUL_PAD ( 2234): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-25 14:23:55.105+0900 D/AUL_PAD ( 2234): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-25 14:23:55.105+0900 D/AUL_PAD ( 2234): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 10887 /opt/usr/apps/org.example.basicui/bin/basicui
03-25 14:23:55.105+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-25 14:23:55.105+0900 D/AUL_PAD (10887): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-25 14:23:55.105+0900 D/AUL_PAD (10887): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-25 14:23:55.105+0900 D/AUL_PAD (10887): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-25 14:23:55.115+0900 D/AUL_PAD (10887): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-25 14:23:55.115+0900 D/AUL_PAD (10887): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-25 14:23:55.115+0900 D/AUL_PAD (10887): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-25 14:23:55.125+0900 D/AUL_PAD (10887): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-25 14:23:55.125+0900 D/LAUNCH  (10887): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-25 14:23:55.125+0900 I/efl-extension(10887): efl_extension.c: eext_mod_init(39) > Init
03-25 14:23:55.125+0900 I/CAPI_APPFW_APPLICATION(10887): app_main.c: ui_app_main(701) > app_efl_main
03-25 14:23:55.125+0900 D/LAUNCH  (10887): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-25 14:23:55.145+0900 D/APP_CORE(10887): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-25 14:23:55.145+0900 D/AUL     (10887): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 10887 is org.example.basicui
03-25 14:23:55.145+0900 D/APP_CORE(10887): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-25 14:23:55.155+0900 D/APP_CORE(10887): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-25 14:23:55.155+0900 D/AUL     (10887): app_sock.c: __create_server_sock(136) > pg path - already exists
03-25 14:23:55.155+0900 D/LAUNCH  (10887): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-25 14:23:55.155+0900 I/CAPI_APPFW_APPLICATION(10887): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-25 14:23:55.185+0900 E/EFL     (10887): eina_module<10887> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-25 14:23:55.195+0900 E/EFL     (10887): ecore_evas<10887> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-25 14:23:55.195+0900 E/EFL     (10887): elementary<10887> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-25 14:23:55.195+0900 E/EFL     (10887): eina_module<10887> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-25 14:23:55.205+0900 D/AUL_PAD ( 2234): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-25 14:23:55.205+0900 D/AUL_PAD ( 2234): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-25 14:23:55.205+0900 D/AUL_PAD ( 2234): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-25 14:23:55.205+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-25 14:23:55.205+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-25 14:23:55.205+0900 D/RESOURCED( 2402): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-25 14:23:55.205+0900 D/RESOURCED( 2402): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2226
03-25 14:23:55.205+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 10887, type 4 
03-25 14:23:55.205+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 10887
03-25 14:23:55.205+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-25 14:23:55.205+0900 E/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 242
03-25 14:23:55.205+0900 D/RESOURCED( 2402): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-25 14:23:55.235+0900 W/CRASH_MANAGER(10745): worker.c: worker_job(1189) > 1110887626173145888343
