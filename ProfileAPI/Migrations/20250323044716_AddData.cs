using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProfileAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.InsertData(
                table: "People",
                columns: new[] { "Name", "Email", "Phone" },
                values: new object[] { "John Doe", "john.doe@example.com", "123-456-7890" });

            mb.InsertData(
                table: "People",
                columns: new[] { "Name", "Email", "Phone" },
                values: new object[] { "Jane Smith", "jane.smith@example.com", "098-765-4321" });

            mb.InsertData(
                table: "People",
                columns: new[] { "Name", "Email", "Phone" },
                values: new object[] { "Alice Johnson", "alice.johnson@example.com", "555-555-5555" });

            mb.InsertData(
                table: "People",
                columns: new[] { "Name", "Email", "Phone" },
                values: new object[] { "Bob Brown", "bob.brown@example.com", "444-444-4444" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
