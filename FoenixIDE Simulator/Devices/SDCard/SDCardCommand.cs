﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoenixIDE.Simulator.Devices.SDCard
{
    public enum SDCommand : byte
    {
        GET_IC_VER = 0x01,
        SET_BAUDRATE = 0x02,
        ENTER_SLEEP = 0x03,
        RESET_ALL = 0x05,
        CHECK_EXIST = 0x06,
        SET_SD0_INT = 0x0b,
        GET_FILE_SIZE = 0x0c,
        SET_USB_MODE = 0x15,
        GET_STATUS = 0x22,
        RD_USB_DATA0 = 0x27,
        WR_USB_DATA = 0x2c,
        WR_REQ_DATA = 0x2d,
        WR_OFS_DATA = 0x2e,
        SET_FILE_NAME = 0x2f,
        DISK_CONNECT = 0x30,
        DISK_MOUNT = 0x31,
        FILE_OPEN = 0x32,
        FILE_ENUM_GO = 0x33,
        FILE_CREATE = 0x34,
        FILE_ERASE = 0x35,
        FILE_CLOSE = 0x36,
        DIR_INF0_READ = 0x37,
        DIR_INF0_SAVE = 0x38,
        BYTE_LOCATE = 0x39,
        BYTE_READ = 0x3a,
        BYTE_RD_GO = 0x3b,
        BYTE_WRITE = 0x3c,
        BYTE_WR_GO = 0x3d,
        DISK_CAPACITY = 0x3e,
        DISK_QUERY = 0x3f,
        DIR_CREATE = 0x40,
        SEG_LOCATE = 0x4A,
        SEC_READ = 0x4b,
        SEC_WRITE = 0x4c,
        DISK_BOC_CMD = 0x50,
        DISK_READ = 0x54,
        DISK_RD_GO = 0x55,
        DISK_WRITE = 0x56,
        DISK_WR_GO = 0x57,
    };
}
