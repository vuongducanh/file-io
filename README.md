                                    Bài tập lọc email;


# Bước 1 : tải một file hoặc tạo một file chấm txt và trong file đó có chứa  emai và tên ;chứng ta cần tạo re một file .txt đẻ lưu kết quả;


# Bài 2: đọc file StreamReader


# Bước 3: bắt đầu lọc email và tên
## 3.1: đây là regex cho email và tên; 
       Regex pattern = new Regex(@".+[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)"); 
## 3.2:sau đó là tạo một cái list ;
        List<string> kq = new List<string>(); 
## 3.2 :chúng ta dung vòng lặp while để mỗi lần chạy là thêm vào list;
# Bước 4:chạy chương trình ;
        dotnet run <tên file .txt>



