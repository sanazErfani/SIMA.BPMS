using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMA.BPMS.Persistance.EF.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Workflow");

            migrationBuilder.CreateTable(
                name: "ActionType",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventInternalTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BpmnId = table.Column<long>(type: "bigint", nullable: false),
                    FileContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Action",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BpmnId = table.Column<long>(type: "bigint", nullable: false),
                    BpmnEventId = table.Column<long>(type: "bigint", nullable: false),
                    WorkflowId = table.Column<long>(type: "bigint", nullable: false),
                    ActionTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Action_ActionType_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalSchema: "Workflow",
                        principalTable: "ActionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Action_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "Workflow",
                        principalTable: "Workflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorSet",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BpmnId = table.Column<long>(type: "bigint", nullable: false),
                    WorkflowId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorSet_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "Workflow",
                        principalTable: "Workflow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Process",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BpmnId = table.Column<long>(type: "bigint", nullable: false),
                    BpmnEventId = table.Column<long>(type: "bigint", nullable: false),
                    WorkflowId = table.Column<long>(type: "bigint", nullable: false),
                    SourceRefId = table.Column<long>(type: "bigint", nullable: false),
                    SourceRefBpmnId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetRefId = table.Column<long>(type: "bigint", nullable: false),
                    TargetRefBpmnId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_Action_SourceRefId",
                        column: x => x.SourceRefId,
                        principalSchema: "Workflow",
                        principalTable: "Action",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Process_Action_TargetRefId",
                        column: x => x.TargetRefId,
                        principalSchema: "Workflow",
                        principalTable: "Action",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Process_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "Workflow",
                        principalTable: "Workflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actor",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BpmnId = table.Column<long>(type: "bigint", nullable: false),
                    WorkflowId = table.Column<long>(type: "bigint", nullable: false),
                    ActorSetId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actor_ActorSet_ActorSetId",
                        column: x => x.ActorSetId,
                        principalSchema: "Workflow",
                        principalTable: "ActorSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Actor_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "Workflow",
                        principalTable: "Workflow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActorAction",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ActorId = table.Column<long>(type: "bigint", nullable: false),
                    ActionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorAction_Action_ActionId",
                        column: x => x.ActionId,
                        principalSchema: "Workflow",
                        principalTable: "Action",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActorAction_Actor_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "Workflow",
                        principalTable: "Actor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Action_ActionTypeId",
                schema: "Workflow",
                table: "Action",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Action_WorkflowId",
                schema: "Workflow",
                table: "Action",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_ActorSetId",
                schema: "Workflow",
                table: "Actor",
                column: "ActorSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_WorkflowId",
                schema: "Workflow",
                table: "Actor",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorAction_ActionId",
                schema: "Workflow",
                table: "ActorAction",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorAction_ActorId",
                schema: "Workflow",
                table: "ActorAction",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorSet_WorkflowId",
                schema: "Workflow",
                table: "ActorSet",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_SourceRefId",
                schema: "Workflow",
                table: "Process",
                column: "SourceRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_TargetRefId",
                schema: "Workflow",
                table: "Process",
                column: "TargetRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_WorkflowId",
                schema: "Workflow",
                table: "Process",
                column: "WorkflowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorAction",
                schema: "Workflow");

            migrationBuilder.DropTable(
                name: "Process",
                schema: "Workflow");

            migrationBuilder.DropTable(
                name: "Actor",
                schema: "Workflow");

            migrationBuilder.DropTable(
                name: "Action",
                schema: "Workflow");

            migrationBuilder.DropTable(
                name: "ActorSet",
                schema: "Workflow");

            migrationBuilder.DropTable(
                name: "ActionType",
                schema: "Workflow");

            migrationBuilder.DropTable(
                name: "Workflow",
                schema: "Workflow");
        }
    }
}
