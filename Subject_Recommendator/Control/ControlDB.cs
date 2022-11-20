﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Subject_Recommendator {
    abstract public class ControlDB {
        // 필드
        string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=schema.mdb";
        OleDbConnection conn;

        // Connection 생성 및 Open
        public void OpenConnection() {
            conn = new OleDbConnection(conStr);
            conn.Open();
        }

        // SQL문 실행(SELECT 연산)
        public OleDbDataReader ExecuteQuery(string sql) {
            OleDbCommand comm = new OleDbCommand(sql, conn);
            return comm.ExecuteReader();
        }

        // SQL문 실행(변경 연산)
        public int ExecuteUpdate(string sql) {
            OleDbCommand comm = new OleDbCommand(sql, conn);
            return comm.ExecuteNonQuery();
        }

        // 추상 메소드 선언: 데이터 새로고침 실행
        abstract public void RefreshData();

        // 추상 메소드 선언: 데이터 새로고침 실행 후처리
        abstract public void RunPostRefreshData();

        // Connection 닫기
        public void CloseConnection() {
            conn.Close();
        }
    }
}
