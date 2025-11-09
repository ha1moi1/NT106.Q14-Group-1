## Bài tập Multiple Socket Connection

### Cách sử dụng

1. Copy link HTTPS: https://github.com/ha1moi1/NT106.Q14-Group-1.git

   Clone dự án bằng lệnh: `git clone https://github.com/ha1moi1/NT106.Q14-Group-1.git`

2. Mở Command Prompt/Power Shell, gõ lệnh `ipconfig` rồi copy IPv4 Address của Mạng đang sử dụng:

**Server:**

+ Truy cập vào NT106.Q14-Group-1\Excercise3\UserManagement\Server.

+ Tìm File `App.config` rồi mở ra.

+ Tại dòng `connectionString="Data Source=127.0.0.1, 1433;`, thay thế địa chỉ IPv4 của `Data Source` bằng địa chỉ IPv4 vừa mới sao chép.

+ Lưu và đóng File lại.

**Client:**

+ Truy cập vào NT106.Q14-Group-1\Excercise3\UserManagement\Client.

+ Tìm File `App.config` rồi mở ra.

+ Tại dòng `<add key="ServerIP" value="127.0.0.1" />`, thay thế địa chỉ IPv4 của `value` bằng địa chỉ IPv4 vừa mới sao chép.

+ Lưu và đóng File lại.

3. Mở `UserManagement.sln`.

**Server:**

+ Chỉnh StartUp Project là Server

![StartUp Project là Server](./images/Server_StartUp_Project.png "Server StartUp Project")

+ Chạy chương trình.

**Client:**

+ Chỉnh StartUp Project là Client

![StartUp Project là Client](./images/Client_StartUp_Project.png "Client StartUp Project")

+ Chạy chương trình.

!!! **Lưu ý:** Client và Server phải kết nối chung một Mạng mới có thể chạy được chương trình.
### Các giao diện màn hình ứng dụng

#### Client

- Giao diện đăng nhập tài khoản 

![Giao diện đăng nhập tài khoản](./images/Client_SignIn_Interface.jpg "Sign In")

- Giao diện đăng ký tài khoản 

![Giao diện đăng ký tài khoản](./images/Client_SignUp_Interface.jpg "Sign Up")

- Giao diện sau đăng nhập

![Giao diện sau đăng nhập](./images/Client_After_SignIn.jpg "After Sign In")

#### Server

- Giao diện Server

![Giao diện Server](./images/Server_Interface.png "Giao diện Server")

- Giao diện Server khi đang Listening

![Giao diện Server khi đang Listening](./images/Server_Listening.png "Server Listening")

- Giao diện Server khi đã có Client kết nối thành công

![Giao diện Server khi đang Listening](./images/Server_Client_Connected.png "Client Connected to Server")

- Giao diện Server khi đã có Client kết nối thành công

![Giao diện Server khi đã có Client kết nối thành công](./images/Server_Client_Connected.png "Client Connected to Server")

- Giao diện danh sách các Client đã kết nối tới Server

![Giao diện danh sách các Client đã kết nối tới Server](./images/Server_Client_List.png "List of Client Connected to Server")

- Giao diện Server khi có Client ngắt kết nối

![Giao diện Server khi có Client ngắt kết nối](./images/Server_Client_Disconnected.png "List of Client Connected to Server")
