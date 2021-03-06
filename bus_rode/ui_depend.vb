﻿
''' <summary>
''' [ui]线路区块中线路含有站台列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_line_stop_list

    ''' <summary>
    ''' 表示在线路模块中的线路车站列表中当前站台的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_stop_name As String

    ''' <summary>
    ''' 表示在线路模块中的线路车站列表中当前站台所停靠车辆的个数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_stop_have_bus_number As Integer

    ''' <summary>
    ''' 表示在线路模块中的线路车站列表中当前站台所停靠车辆的相关信息
    ''' </summary>
    ''' <returns></returns>
    Public Property ui_stop_have_bus_message As String

    ''' <summary>
    ''' 在线路模块中的线路车站列表中当前站台所停靠车辆的个数所对应的应当显示的颜色 没有车：RGB：255，255，255     1辆车：RGB：255，204，204     2辆车：RGB：255，153，153     3辆车：RGB：255，102，102     4辆车：RGB：255，51，51     5辆车及以上：RGB：255，0，0
    ''' </summary>
    ''' <returns></returns>
    Public Property ui_stop_have_bus_number_color As SolidColorBrush

End Class

''' <summary>
''' [ui]线路区块中选择线路列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_line_list

    ''' <summary>
    ''' 选择线路列表中每个线路的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_line_name As String

End Class

''' <summary>
''' [ui]线路区块中搜索线路含有站台列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_line_search_stop_list

    ''' <summary>
    ''' 搜索线路中含有站台列表中每个搜索到的站台的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_line_of_stop_name As String

    ''' <summary>
    ''' 搜索线路中含有站台列表中每个搜索到的站台是在上行还是下行
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_line_of_stop_name_on_where As String

End Class

''' <summary>
''' [ui]线路区块中地铁线路列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_line_subway_list

    ''' <summary>
    ''' 地铁出口的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_exit_name As String

    ''' <summary>
    ''' 地铁出口的通向
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_go_to As String

End Class


''' <summary>
''' [ui]车站区块中车站经过车次列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_stop_cross_line_list

    ''' <summary>
    ''' 站台的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_stop_name As String

    ''' <summary>
    ''' 经过车次的文本
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_cross_line As String

End Class
''' <summary>
''' [ui]车站区块中真实站台列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_stop_realistic_stop_list

    ''' <summary>
    ''' 线路的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_line_name As String

    ''' <summary>
    ''' 在真实站台上行中的线路谁离得最近 6站以上或没车：RGB：255，255，255     5站：RGB：255，204，204     4站：RGB：255，153，153     3站：RGB：255，102，102     2站：RGB：255，51，51     1站：RGB：255，0，0
    ''' </summary>
    ''' <returns></returns>
    Public Property ui_up_bk_color As SolidColorBrush
    ''' <summary>
    ''' 在真实站台中下行的线路谁离得最近 6站以上或没车：RGB：255，255，255     5站：RGB：255，204，204     4站：RGB：255，153，153     3站：RGB：255，102，102     2站：RGB：255，51，51     1站：RGB：255，0，0
    ''' </summary>
    ''' <returns></returns>
    Public Property ui_down_bk_color As SolidColorBrush

    '==================================================
    ''' <summary>
    ''' 上行线路方向，格式：（起始-[第二站]-终到）仅在环线时标明第二站
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_up_line_toward As String

    ''' <summary>
    ''' 上行线路描述1-最近车辆
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_up_line_describe_1 As String
    ''' <summary>
    ''' 上行线路描述2-第二近车辆
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_up_line_describe_2 As String

    '==================================================
    ''' <summary>
    ''' 下行线路方向，格式：（起始-[第二站]-终到）仅在环线时标明第二站
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_down_line_toward As String

    ''' <summary>
    ''' 下行线路描述1-最近车辆
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_down_line_describe_1 As String
    ''' <summary>
    ''' 下行线路描述2-第二近车辆
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_down_line_describe_2 As String

End Class
''' <summary>
''' [ui]车站区块中车站列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_stop_list

    ''' <summary>
    ''' 站台的名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_stop_name As String

End Class

''' <summary>
''' [ui]开始通知界面的列表项
''' </summary>
Public Class ui_depend_start_ring_list

    ''' <summary>
    ''' 线路名
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_line As String

    ''' <summary>
    ''' 靠近的站点数
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_close_stop_number As Integer

    ''' <summary>
    ''' 靠近站点数的描述
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_close_stop_describe As String

End Class



''' <summary>
''' [ui]消息区块消息列表列表中每项对应数据类
''' </summary>
''' <remarks></remarks>
Public Class ui_depend_message_list

    ''' <summary>
    ''' 消息标题
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_msg_title As String

    ''' <summary>
    ''' 消息正文
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_msg_text As String

    ''' <summary>
    ''' 消息时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ui_msg_date As String

End Class

''' <summary>
''' 窗口-选择项使用的类
''' </summary>
Public Class ui_depend_window_select_item_list
    ''' <summary>
    ''' 标题
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_title As String
    ''' <summary>
    ''' 文本
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_text As String
    ''' <summary>
    ''' 填充画刷，选中的话就填为 #ff1e90ff 未选中填 #00000000
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_fill As SolidColorBrush

    ''' <summary>
    ''' 是否选中
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_is_select As Boolean

    ''' <summary>
    ''' 多选时的透明度，选中填1，未选中填0
    ''' </summary>
    ''' <returns></returns>
    Public Property pro_opacity As Double = 0

End Class