using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFullDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccType",
                columns: table => new
                {
                    TypeCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccType", x => x.TypeCode);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    Tier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenId = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    GovId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MemStatus = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustCode);
                });

            migrationBuilder.CreateTable(
                name: "DocType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccDpst",
                columns: table => new
                {
                    AccCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    AccTypeTypeCode = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    AccId = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    CustCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    CustomerCustCode = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    UsableAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AvaliableAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TransferDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    AccStatus = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccDpst", x => x.AccCode);
                    table.ForeignKey(
                        name: "FK_AccDpst_AccType_AccTypeTypeCode",
                        column: x => x.AccTypeTypeCode,
                        principalTable: "AccType",
                        principalColumn: "TypeCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccDpst_Customer_CustomerCustCode",
                        column: x => x.CustomerCustCode,
                        principalTable: "Customer",
                        principalColumn: "CustCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccLoan",
                columns: table => new
                {
                    AccCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    AccTypeTypeCode = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    AccId = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    CustCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    CustomerCustCode = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    MaxloanAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    WithdrawAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    InstallAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PrincipalAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TransferDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    AccStatus = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccLoan", x => x.AccCode);
                    table.ForeignKey(
                        name: "FK_AccLoan_AccType_AccTypeTypeCode",
                        column: x => x.AccTypeTypeCode,
                        principalTable: "AccType",
                        principalColumn: "TypeCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccLoan_Customer_CustomerCustCode",
                        column: x => x.CustomerCustCode,
                        principalTable: "Customer",
                        principalColumn: "CustCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileEBook = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doc_DocType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "DocType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransDpst",
                columns: table => new
                {
                    TransCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    AccCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    AccDpstAccCode = table.Column<string>(type: "nvarchar(38)", nullable: true),
                    Status01 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Status02 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Status03 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Status04 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    WithdrawAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DpstAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    UsableAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DpstDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CreateTime = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    ApproveDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ApproveTime = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    TransDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    TransferDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransDpst", x => x.TransCode);
                    table.ForeignKey(
                        name: "FK_TransDpst_AccDpst_AccDpstAccCode",
                        column: x => x.AccDpstAccCode,
                        principalTable: "AccDpst",
                        principalColumn: "AccCode");
                });

            migrationBuilder.CreateTable(
                name: "TransLoan",
                columns: table => new
                {
                    TransCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    AccCode = table.Column<string>(type: "nvarchar(38)", maxLength: 38, nullable: false),
                    AccLoanAccCode = table.Column<string>(type: "nvarchar(38)", nullable: true),
                    Status01 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Status02 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Status03 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Status04 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PayoutAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PayinPrincipalAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PayinInterestAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PayinPenaltyAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PayinInsureAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PrincipalAmt = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PayinForDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CreateDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CreateTime = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    ApproveDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ApproveTime = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    TransDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    TransferDate = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransLoan", x => x.TransCode);
                    table.ForeignKey(
                        name: "FK_TransLoan_AccLoan_AccLoanAccCode",
                        column: x => x.AccLoanAccCode,
                        principalTable: "AccLoan",
                        principalColumn: "AccCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccDpst_AccTypeTypeCode",
                table: "AccDpst",
                column: "AccTypeTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_AccDpst_CustomerCustCode",
                table: "AccDpst",
                column: "CustomerCustCode");

            migrationBuilder.CreateIndex(
                name: "IX_AccLoan_AccTypeTypeCode",
                table: "AccLoan",
                column: "AccTypeTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_AccLoan_CustomerCustCode",
                table: "AccLoan",
                column: "CustomerCustCode");

            migrationBuilder.CreateIndex(
                name: "IX_Doc_TypeId",
                table: "Doc",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransDpst_AccDpstAccCode",
                table: "TransDpst",
                column: "AccDpstAccCode");

            migrationBuilder.CreateIndex(
                name: "IX_TransLoan_AccLoanAccCode",
                table: "TransLoan",
                column: "AccLoanAccCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doc");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "TransDpst");

            migrationBuilder.DropTable(
                name: "TransLoan");

            migrationBuilder.DropTable(
                name: "DocType");

            migrationBuilder.DropTable(
                name: "AccDpst");

            migrationBuilder.DropTable(
                name: "AccLoan");

            migrationBuilder.DropTable(
                name: "AccType");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
