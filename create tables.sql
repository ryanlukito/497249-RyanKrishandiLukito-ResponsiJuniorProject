create table departemen
(
id_departemen serial primary key,
nama_dept character VARYING (20)
);


create SEQUENCE emp_id start 001;

create table jabatan
(
id_jabatan serial primary key,
nama_jabatan character VARYING (50),
salary numeric(12,2)
);

create table karyawan
(
id_karyawan character VARYING (20) default 'EMP'|| nextval('emp_id') primary key,
nama character VARYING (20),
id_dept int,
id_jab int,
FOREIGN KEY (id_dept) REFERENCES departemen (id_departemen),
FOREIGN KEY (id_jab) REFERENCES jabatan (id_jabatan)
);
