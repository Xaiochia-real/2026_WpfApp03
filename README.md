更新 WPF 小畫家：

    1. 介面佈局與選單系統 (UI & Layout)
        ● 主視窗結構 (DockPanel)：
            ○ 頂部選單 (Menu)：提供檔案管理選單（如「開啟新畫布」、「儲存畫布」）。
            ○ 工具列托盤 (ToolBarTray)：整合兩個工具列，包含樣式設定（顏色選擇器、筆刷粗細滑桿）與繪圖工具（形狀切換按鈕、橡皮擦、清除按鈕）。
            ○ 底部狀態列 (StatusBar)：即時呈現當前的工作模式、圖形座標、筆刷與填充色彩資訊。
            ○ 中央繪圖區 (Canvas)：採用絕對座標定位，作為所有向量圖形繪製與渲染的容器。

    2. 繪圖與工具功能 (Drawing & Tools)
        ● 多種向量圖形繪製：
            ○ 支援繪製 直線 (Line)、矩形 (Rectangle)、橢圓 (Ellipse) 與 多折線 (Polyline)。
        ● 樣式與色彩控制：
            ○ 引入第三方套件 Extended WPF Toolkit 的 ColorPicker，支援自訂 筆刷色彩 (Stroke) 與 填滿色彩 (Fill)。
            ○ 透過 Slider 控制項調整 筆刷粗細 (Thickness)。
        ● 畫布編輯與清除：
            ○ 橡皮擦模式 (Eraser)：點擊圖形元件即可透過 MyCanvas.Children.Remove() 將該圖形刪除。
            ○ 一鍵清空 (Clear)：執行 MyCanvas.Children.Clear() 快速清除畫布上的所有圖形。

橡皮擦功能會出bug，但目前懶的修復了...
